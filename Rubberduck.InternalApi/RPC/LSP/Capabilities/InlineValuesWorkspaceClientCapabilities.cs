﻿using System.Text.Json.Serialization;

namespace Rubberduck.InternalApi.RPC.LSP.Capabilities
{
    public class InlineValuesWorkspaceClientCapabilities
    {
        /// <summary>
        /// Whether the client supports a refresh request sent from the server to the client.
        /// </summary>
        /// <remarks>
        /// This event is global and will force the client to refresh all inline values currently shown. Use carefully.
        /// </remarks>
        [JsonPropertyName("refreshSupport")]
        public bool SupportsRefresh { get; set; }
    }
}
