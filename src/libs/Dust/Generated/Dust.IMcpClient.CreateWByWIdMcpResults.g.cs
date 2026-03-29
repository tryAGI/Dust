#nullable enable

namespace Dust
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Submit MCP tool execution results<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Endpoint for client-side MCP servers to submit the results of tool executions.<br/>
        /// This endpoint accepts the output from tools that were executed locally.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdMcpResultsAsync(
            string wId,

            global::Dust.CreateWMcpResultsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit MCP tool execution results<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Endpoint for client-side MCP servers to submit the results of tool executions.<br/>
        /// This endpoint accepts the output from tools that were executed locally.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="result">
        /// The result data from the tool execution
        /// </param>
        /// <param name="serverId">
        /// ID of the MCP server submitting the results
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdMcpResultsAsync(
            string wId,
            object result,
            string serverId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}