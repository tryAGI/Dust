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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdTriggersHooksByWebhookSourceIdAsync(
            string wId,
            string webhookSourceId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Receive external webhook to trigger flows<br/>
        /// Skeleton endpoint that verifies workspace and webhook source and logs receipt.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="webhookSourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdTriggersHooksByWebhookSourceIdAsync(
            string wId,
            string webhookSourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}