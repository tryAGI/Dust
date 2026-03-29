#nullable enable

namespace Dust
{
    public partial interface IPrivateAgentsClient
    {
        /// <summary>
        /// Create an agent configuration<br/>
        /// Creates a new agent configuration in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantAgentConfigurationsResponse> CreateWByWIdAssistantAgentConfigurationsAsync(
            string wId,

            global::Dust.CreateWAssistantAgentConfigurationsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent configuration<br/>
        /// Creates a new agent configuration in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="assistant">
        /// Agent configuration to create
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantAgentConfigurationsResponse> CreateWByWIdAssistantAgentConfigurationsAsync(
            string wId,
            object assistant,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}