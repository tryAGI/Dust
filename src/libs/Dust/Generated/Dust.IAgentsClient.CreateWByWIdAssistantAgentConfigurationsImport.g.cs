#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Import agent configuration<br/>
        /// Create a new agent configuration from a JSON body matching the agent config schema.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantAgentConfigurationsImportResponse> CreateWByWIdAssistantAgentConfigurationsImportAsync(
            string wId,

            global::Dust.CreateWAssistantAgentConfigurationsImportRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import agent configuration<br/>
        /// Create a new agent configuration from a JSON body matching the agent config schema.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="agent"></param>
        /// <param name="instructions"></param>
        /// <param name="generationSettings"></param>
        /// <param name="tags"></param>
        /// <param name="editors"></param>
        /// <param name="toolset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantAgentConfigurationsImportResponse> CreateWByWIdAssistantAgentConfigurationsImportAsync(
            string wId,
            global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgent agent,
            string instructions,
            global::Dust.CreateWAssistantAgentConfigurationsImportRequestGenerationSettings generationSettings,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag> tags,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestEditor> editors,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem> toolset,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}