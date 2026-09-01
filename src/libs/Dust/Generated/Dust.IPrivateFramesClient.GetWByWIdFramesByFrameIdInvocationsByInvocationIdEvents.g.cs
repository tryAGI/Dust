#nullable enable

namespace Dust
{
    public partial interface IPrivateFramesClient
    {
        /// <summary>
        /// Stream Frames v2 function invocation events<br/>
        /// Authorizes through the stable Frame identity and redirects to the SSE service. The invocation's own publication is used, so a republish cannot break an existing stream.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="frameId"></param>
        /// <param name="invocationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Dust.PrivateSandboxFunctionInvocationEvent> GetWByWIdFramesByFrameIdInvocationsByInvocationIdEventsAsync(
            string wId,
            string frameId,
            string invocationId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}