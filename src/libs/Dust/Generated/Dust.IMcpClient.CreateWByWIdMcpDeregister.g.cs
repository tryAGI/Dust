#nullable enable

namespace Dust
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Deregister a client-side MCP server<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Remove a previously registered client-side MCP server registration.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdMcpDeregisterAsync(
            string wId,

            global::Dust.CreateWMcpDeregisterRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deregister a client-side MCP server<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Remove a previously registered client-side MCP server registration.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse> CreateWByWIdMcpDeregisterAsResponseAsync(
            string wId,

            global::Dust.CreateWMcpDeregisterRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deregister a client-side MCP server<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Remove a previously registered client-side MCP server registration.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="serverId">
        /// The ID of the registered MCP server
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdMcpDeregisterAsync(
            string wId,
            string serverId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}