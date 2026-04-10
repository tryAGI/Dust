#nullable enable

namespace Dust
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Register a client-side MCP server<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Register a client-side MCP server to Dust.<br/>
        /// The registration is scoped to the current user and workspace.<br/>
        /// A serverId identifier is generated and returned in the response.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWMcpRegisterResponse> CreateWByWIdMcpRegisterAsync(
            string wId,

            global::Dust.CreateWMcpRegisterRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a client-side MCP server<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Register a client-side MCP server to Dust.<br/>
        /// The registration is scoped to the current user and workspace.<br/>
        /// A serverId identifier is generated and returned in the response.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="serverName">
        /// Name of the MCP server
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWMcpRegisterResponse> CreateWByWIdMcpRegisterAsync(
            string wId,
            string serverName,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}