#nullable enable

namespace Dust
{
    public partial interface IPrivateFramesClient
    {
        /// <summary>
        /// Invoke an active Frames v2 function<br/>
        /// Resolves a bare function name from the Frame's active immutable publication, checks Frame use rights, and starts an invocation pinned to that publication.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="frameId"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PrivateFrameFunctionInvocationResponse> CreateWByWIdFramesByFrameIdFunctionsByNameInvocationsAsync(
            string wId,
            string frameId,
            string name,

            global::Dust.PrivateFrameFunctionInvocationRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoke an active Frames v2 function<br/>
        /// Resolves a bare function name from the Frame's active immutable publication, checks Frame use rights, and starts an invocation pinned to that publication.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="frameId"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.PrivateFrameFunctionInvocationResponse>> CreateWByWIdFramesByFrameIdFunctionsByNameInvocationsAsResponseAsync(
            string wId,
            string frameId,
            string name,

            global::Dust.PrivateFrameFunctionInvocationRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoke an active Frames v2 function<br/>
        /// Resolves a bare function name from the Frame's active immutable publication, checks Frame use rights, and starts an invocation pinned to that publication.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="frameId"></param>
        /// <param name="name"></param>
        /// <param name="input">
        /// Input validated against the published function contract.
        /// </param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PrivateFrameFunctionInvocationResponse> CreateWByWIdFramesByFrameIdFunctionsByNameInvocationsAsync(
            string wId,
            string frameId,
            string name,
            object? input = default,
            global::Dust.PrivateFrameFunctionInvocationRequestContext? context = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}