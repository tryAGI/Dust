#nullable enable

namespace Dust
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Update heartbeat for a client-side MCP server<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Update the heartbeat for a previously registered client-side MCP server.<br/>
        /// This extends the TTL for the server registration.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWMcpHeartbeatResponse> CreateWByWIdMcpHeartbeatAsync(
            string wId,

            global::Dust.CreateWMcpHeartbeatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update heartbeat for a client-side MCP server<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Update the heartbeat for a previously registered client-side MCP server.<br/>
        /// This extends the TTL for the server registration.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="serverId">
        /// The ID of the registered MCP server
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWMcpHeartbeatResponse> CreateWByWIdMcpHeartbeatAsync(
            string wId,
            string serverId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}