#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Search agents by name<br/>
        /// Search for agent configurations by name in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="q"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantAgentConfigurationsSearchResponse> GetWByWIdAssistantAgentConfigurationsSearchAsync(
            string wId,
            string q,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}