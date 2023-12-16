﻿using Rubberduck.InternalApi.Model.Workspace;
using Rubberduck.UI.Services.WorkspaceExplorer;
using Rubberduck.UI.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Rubberduck.UI.WorkspaceExplorer
{
    public interface IWorkspaceExplorerViewModel : IToolWindowViewModel
    {
        void Load(ProjectFile workspace);
        WorkspaceTreeNodeViewModel? Selection { get; set; }
        IWorkspaceUriInfo? SelectionInfo { get; }
        bool HasSelectionInfo { get; }
        ObservableCollection<WorkspaceViewModel> Workspaces { get; }
    }
}
