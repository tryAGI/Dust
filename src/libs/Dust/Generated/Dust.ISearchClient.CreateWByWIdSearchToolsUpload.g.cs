#nullable enable

namespace Dust
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Upload a tool file<br/>
        /// Download and upload a file from a tool (MCP server) to Dust
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdSearchToolsUploadAsync(
            string wId,

            global::Dust.CreateWSearchToolsUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a tool file<br/>
        /// Download and upload a file from a tool (MCP server) to Dust
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="serverViewId">
        /// The MCP server view ID
        /// </param>
        /// <param name="externalId">
        /// The external ID of the file in the tool
        /// </param>
        /// <param name="conversationId">
        /// Optional conversation ID for context
        /// </param>
        /// <param name="serverName">
        /// Optional name of the MCP server (e.g., "Notion", "GitHub")
        /// </param>
        /// <param name="serverIcon">
        /// Optional icon identifier for the MCP server
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdSearchToolsUploadAsync(
            string wId,
            string serverViewId,
            string externalId,
            string? conversationId = default,
            string? serverName = default,
            string? serverIcon = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}