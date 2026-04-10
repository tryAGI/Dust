#nullable enable

namespace Dust
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Stream MCP tool requests for a workspace<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Server-Sent Events (SSE) endpoint that streams MCP tool requests for a workspace.<br/>
        /// This endpoint is used by client-side MCP servers to listen for tool requests in real-time.<br/>
        /// The connection will remain open and events will be sent as new tool requests are made.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="serverId"></param>
        /// <param name="lastEventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Dust.GetWMcpRequestsResponse> GetWByWIdMcpRequestsAsync(
            string wId,
            string serverId,
            string? lastEventId = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}