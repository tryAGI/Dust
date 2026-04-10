#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agents<br/>
        /// Get the agent configurations for the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="view"></param>
        /// <param name="withAuthors"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantAgentConfigurationsResponse> GetWByWIdAssistantAgentConfigurationsAsync(
            string wId,
            global::Dust.GetWAssistantAgentConfigurationsView? view = default,
            global::Dust.GetWAssistantAgentConfigurationsWithAuthors? withAuthors = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}