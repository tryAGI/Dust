#nullable enable

namespace Dust
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Receive external webhook to trigger flows<br/>
        /// Skeleton endpoint that verifies workspace and webhook source and logs receipt.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="webhookSourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdTriggersHooksByWebhookSourceIdAsync(
            string wId,
            string webhookSourceId,

            object request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Receive external webhook to trigger flows<br/>
        /// Skeleton endpoint that verifies workspace and webhook source and logs receipt.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="webhookSourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdTriggersHooksByWebhookSourceIdAsync(
            string wId,
            string webhookSourceId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}