#nullable enable

namespace Dust
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// List skills<br/>
        /// Retrieves the custom skills in the workspace. Active skills are returned by default.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSkillsResponse> GetWByWIdSkillsAsync(
            string wId,
            global::Dust.GetWSkillsStatus? status = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}