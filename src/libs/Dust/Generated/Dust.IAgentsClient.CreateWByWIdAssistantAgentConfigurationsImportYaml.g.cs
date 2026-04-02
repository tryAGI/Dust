#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Import agent configuration from YAML<br/>
        /// Create a new agent configuration from a JSON body matching the agent YAML config schema.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantAgentConfigurationsImportYamlResponse> CreateWByWIdAssistantAgentConfigurationsImportYamlAsync(
            string wId,

            global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import agent configuration from YAML<br/>
        /// Create a new agent configuration from a JSON body matching the agent YAML config schema.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="agent"></param>
        /// <param name="instructions"></param>
        /// <param name="generationSettings"></param>
        /// <param name="tags"></param>
        /// <param name="editors"></param>
        /// <param name="toolset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantAgentConfigurationsImportYamlResponse> CreateWByWIdAssistantAgentConfigurationsImportYamlAsync(
            string wId,
            global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestAgent agent,
            string instructions,
            global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestGenerationSettings generationSettings,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestTag> tags,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestEditor> editors,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItem> toolset,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}