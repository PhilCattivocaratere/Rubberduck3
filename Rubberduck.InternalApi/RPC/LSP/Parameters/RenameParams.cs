﻿using System.Text.Json.Serialization;

namespace Rubberduck.InternalApi.RPC.LSP.Parameters
{
    public class RenameParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        /// <summary>
        /// A token that the server can use to report work done progress.
        /// </summary>
        [JsonPropertyName("workDoneToken")]
        public string WorkDoneToken { get; set; }

        /// <summary>
        /// The new name of the symbol. If the given name is invalid the request must return a ResponseError with an appropriate message set.
        /// </summary>
        [JsonPropertyName("newName")]
        public string NewName { get; set; }
    }
}
