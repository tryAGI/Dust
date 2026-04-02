#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update agent configuration<br/>
        /// Update the agent configuration identified by {sId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="sId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantAgentConfigurationsResponse> EditWByWIdAssistantAgentConfigurationsBySIdAsync(
            string wId,
            string sId,

            global::Dust.PatchWAssistantAgentConfigurationsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent configuration<br/>
        /// Update the agent configuration identified by {sId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="sId"></param>
        /// <param name="userFavorite"></param>
        /// <param name="agent"></param>
        /// <param name="instructions"></param>
        /// <param name="generationSettings"></param>
        /// <param name="tags"></param>
        /// <param name="editors"></param>
        /// <param name="toolset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantAgentConfigurationsResponse> EditWByWIdAssistantAgentConfigurationsBySIdAsync(
            string wId,
            string sId,
            bool? userFavorite = default,
            global::Dust.PatchWAssistantAgentConfigurationsRequestAgent? agent = default,
            string? instructions = default,
            global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings? generationSettings = default,
            global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>? tags = default,
            global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestEditor>? editors = default,
            global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>? toolset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}