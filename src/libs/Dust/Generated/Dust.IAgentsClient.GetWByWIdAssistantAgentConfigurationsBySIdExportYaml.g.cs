#nullable enable

namespace Dust
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Export agent configuration as YAML<br/>
        /// Download the agent configuration identified by {sId} as a YAML file.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="sId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWByWIdAssistantAgentConfigurationsBySIdExportYamlAsync(
            string wId,
            string sId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}