#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get agent configuration<br/>
        /// Retrieve the agent configuration identified by {sId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="sId"></param>
        /// <param name="variant">
        /// Default Value: light
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantAgentConfigurationsResponse2> GetWByWIdAssistantAgentConfigurationsBySIdAsync(
            string wId,
            string sId,
            global::Dust.GetWAssistantAgentConfigurationsVariant? variant = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}