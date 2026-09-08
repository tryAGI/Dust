#nullable enable

namespace Dust
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Get a trigger<br/>
        /// Get one agent trigger (scheduled run or webhook) by id. Requires a workspace admin API<br/>
        /// key.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="tId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWTriggersResponse> GetWByWIdTriggersByTIdAsync(
            string wId,
            string tId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a trigger<br/>
        /// Get one agent trigger (scheduled run or webhook) by id. Requires a workspace admin API<br/>
        /// key.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="tId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.GetWTriggersResponse>> GetWByWIdTriggersByTIdAsResponseAsync(
            string wId,
            string tId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}