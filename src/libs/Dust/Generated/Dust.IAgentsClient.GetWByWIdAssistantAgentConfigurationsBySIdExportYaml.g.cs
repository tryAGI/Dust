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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWByWIdAssistantAgentConfigurationsBySIdExportYamlAsync(
            string wId,
            string sId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export agent configuration as YAML<br/>
        /// Download the agent configuration identified by {sId} as a YAML file.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="sId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<string>> GetWByWIdAssistantAgentConfigurationsBySIdExportYamlAsResponseAsync(
            string wId,
            string sId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}