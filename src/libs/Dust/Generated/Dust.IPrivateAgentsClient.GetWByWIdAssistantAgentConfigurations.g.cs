#nullable enable

namespace Dust
{
    public partial interface IPrivateAgentsClient
    {
        /// <summary>
        /// List agent configurations<br/>
        /// Returns all agent configurations in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="view"></param>
        /// <param name="limit"></param>
        /// <param name="withUsage"></param>
        /// <param name="withAuthors"></param>
        /// <param name="withFeedbacks"></param>
        /// <param name="withEditors"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantAgentConfigurationsResponse3> GetWByWIdAssistantAgentConfigurationsAsync(
            string wId,
            global::Dust.GetWAssistantAgentConfigurationsView2? view = default,
            int? limit = default,
            global::Dust.GetWAssistantAgentConfigurationsWithUsage? withUsage = default,
            global::Dust.GetWAssistantAgentConfigurationsWithAuthors2? withAuthors = default,
            global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks? withFeedbacks = default,
            global::Dust.GetWAssistantAgentConfigurationsWithEditors? withEditors = default,
            string? sort = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}