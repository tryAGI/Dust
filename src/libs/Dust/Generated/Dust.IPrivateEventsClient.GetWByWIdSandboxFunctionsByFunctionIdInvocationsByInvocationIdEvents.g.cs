#nullable enable

namespace Dust
{
    public partial interface IPrivateEventsClient
    {
        /// <summary>
        /// Stream sandbox function invocation events<br/>
        /// Stream real-time events for a sandbox function invocation using Server-Sent Events (SSE). This endpoint is redirected to /api/sse/ for SSE traffic routing.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="functionId"></param>
        /// <param name="invocationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Dust.PrivateSandboxFunctionInvocationEvent> GetWByWIdSandboxFunctionsByFunctionIdInvocationsByInvocationIdEventsAsync(
            string wId,
            string functionId,
            string invocationId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}