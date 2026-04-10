#nullable enable

namespace Dust
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List available MCP server views.<br/>
        /// Retrieves a list of enabled MCP server views (aka tools) for a specific space of the authenticated workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesMcpServerViewsResponse> GetWByWIdSpacesBySpaceIdMcpServerViewsAsync(
            string wId,
            string spaceId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}