#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Archive agent configuration<br/>
        /// Archive the agent configuration identified by {sId} in the workspace identified by {wId}. The agent is soft-archived and triggers/editor-group memberships associated with it are disabled.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="sId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.DeleteWAssistantAgentConfigurationsResponse> DeleteWByWIdAssistantAgentConfigurationsBySIdAsync(
            string wId,
            string sId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive agent configuration<br/>
        /// Archive the agent configuration identified by {sId} in the workspace identified by {wId}. The agent is soft-archived and triggers/editor-group memberships associated with it are disabled.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="sId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.DeleteWAssistantAgentConfigurationsResponse>> DeleteWByWIdAssistantAgentConfigurationsBySIdAsResponseAsync(
            string wId,
            string sId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}