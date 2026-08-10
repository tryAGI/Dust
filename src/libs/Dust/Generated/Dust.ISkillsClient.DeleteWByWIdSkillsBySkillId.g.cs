#nullable enable

namespace Dust
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Archive a skill<br/>
        /// Soft-archives a custom skill in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="skillId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.DeleteWSkillsResponse> DeleteWByWIdSkillsBySkillIdAsync(
            string wId,
            string skillId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive a skill<br/>
        /// Soft-archives a custom skill in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="skillId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.DeleteWSkillsResponse>> DeleteWByWIdSkillsBySkillIdAsResponseAsync(
            string wId,
            string skillId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}