#nullable enable

namespace Dust
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// List triggers<br/>
        /// List the agent triggers (scheduled runs and webhooks) configured across the workspace<br/>
        /// identified by {wId}. Requires a workspace admin API key.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="kind"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWTriggersResponse> GetWByWIdTriggersAsync(
            string wId,
            global::Dust.GetWTriggersKind? kind = default,
            int? limit = default,
            int? offset = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List triggers<br/>
        /// List the agent triggers (scheduled runs and webhooks) configured across the workspace<br/>
        /// identified by {wId}. Requires a workspace admin API key.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="kind"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.GetWTriggersResponse>> GetWByWIdTriggersAsResponseAsync(
            string wId,
            global::Dust.GetWTriggersKind? kind = default,
            int? limit = default,
            int? offset = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}