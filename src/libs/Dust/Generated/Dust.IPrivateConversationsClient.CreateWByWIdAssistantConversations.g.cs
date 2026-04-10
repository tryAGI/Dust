#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Create a conversation<br/>
        /// Create a new conversation, optionally with an initial user message and content fragments.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsResponse> CreateWByWIdAssistantConversationsAsync(
            string wId,

            global::Dust.CreateWAssistantConversationsRequest2 request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a conversation<br/>
        /// Create a new conversation, optionally with an initial user message and content fragments.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="title"></param>
        /// <param name="visibility"></param>
        /// <param name="spaceId"></param>
        /// <param name="message"></param>
        /// <param name="contentFragments"></param>
        /// <param name="metadata"></param>
        /// <param name="skipToolsValidation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsResponse> CreateWByWIdAssistantConversationsAsync(
            string wId,
            string? title = default,
            global::Dust.CreateWAssistantConversationsRequestVisibility? visibility = default,
            string? spaceId = default,
            global::Dust.CreateWAssistantConversationsRequestMessage? message = default,
            global::System.Collections.Generic.IList<object>? contentFragments = default,
            object? metadata = default,
            bool? skipToolsValidation = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}