#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Create a content fragment<br/>
        /// Post a new content fragment to an existing conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsContentFragmentResponse> CreateWByWIdAssistantConversationsByCIdContentFragmentAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsContentFragmentRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a content fragment<br/>
        /// Post a new content fragment to an existing conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="contentType">
        /// MIME type of the content
        /// </param>
        /// <param name="url"></param>
        /// <param name="context"></param>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsContentFragmentResponse> CreateWByWIdAssistantConversationsByCIdContentFragmentAsync(
            string wId,
            string cId,
            string title,
            string content,
            string contentType,
            global::Dust.CreateWAssistantConversationsContentFragmentRequestContext context,
            string? url = default,
            string? fileId = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}