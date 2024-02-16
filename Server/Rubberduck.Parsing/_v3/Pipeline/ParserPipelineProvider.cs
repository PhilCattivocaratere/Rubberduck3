﻿using NLog.Config;
using Rubberduck.InternalApi.Extensions;
using Rubberduck.Parsing._v3.Pipeline.Abstract;
using System.Collections.Concurrent;

namespace Rubberduck.Parsing._v3.Pipeline;

public class ParserPipelineProvider
{
    private readonly IParserPipelineFactory<WorkspaceParserPipeline> _workspacePipelineFactory;
    private readonly IParserPipelineFactory<WorkspaceFileSection> _fileParserPipelineFactory;
    private readonly IParserPipelineFactory<DocumentMembersPipeline> _membersPipelineFactory;
    private readonly IParserPipelineFactory<HierarchicalSymbolsPipeline> _symbolsPipelineFactory;

    private readonly ConcurrentDictionary<Uri, IParserPipeline> _pipelines = [];
    private readonly ConcurrentDictionary<Uri, Task> _tasks = [];

    public ParserPipelineProvider(
        IParserPipelineFactory<WorkspaceParserPipeline> workspacePipelineFactory,
        IParserPipelineFactory<WorkspaceFileSection> fileParserPipelineFactory,
        IParserPipelineFactory<DocumentMembersPipeline> membersPipelineFactory,
        IParserPipelineFactory<HierarchicalSymbolsPipeline> symbolsPipelineFactory)
    {
        _workspacePipelineFactory = workspacePipelineFactory;
        _fileParserPipelineFactory = fileParserPipelineFactory;
        _membersPipelineFactory = membersPipelineFactory;
        _symbolsPipelineFactory = symbolsPipelineFactory;
    }

    public WorkspaceParserPipeline StartNew(WorkspaceUri uri, CancellationTokenSource? tokenSource)
    {
        _ = uri ?? throw new ArgumentNullException(nameof(uri));

        if (_pipelines.TryGetValue(uri, out var pipeline))
        {
            try
            {
                pipeline.Cancel();
            }
            finally
            {
                _tasks.Remove(uri, out _);
            }
        }

        var newPipeline = _workspacePipelineFactory.Create();
        var completion = newPipeline.StartAsync(uri, null, tokenSource);

        _tasks.TryAdd(uri, completion);
        _pipelines[uri] = newPipeline;

        return newPipeline;
    }

    public WorkspaceDocumentSection StartNew(WorkspaceFileUri uri, CancellationTokenSource? tokenSource)
    {
        _ = uri ?? throw new ArgumentNullException(nameof(uri));

        if (_pipelines.TryGetValue(uri, out var pipeline))
        {
            try
            {
                pipeline.Cancel();
            }
            finally
            {
                _tasks.Remove(uri, out _);
            }
        }

        var newPipeline = _fileParserPipelineFactory.Create();
        var completion = newPipeline.StartAsync(uri, null, tokenSource);

        _tasks.TryAdd(uri, completion);
        _pipelines[uri] = newPipeline;

        return newPipeline;
    }

    public WorkspaceParserPipeline? GetCurrent(WorkspaceUri uri) =>
        _pipelines.TryGetValue(uri, out var current) && current is WorkspaceParserPipeline result ? result : null;

    public WorkspaceFileSection? GetCurrent(WorkspaceFileUri uri) =>
        _pipelines.TryGetValue(uri, out var current) && current is WorkspaceFileSection result ? result : null;
}
