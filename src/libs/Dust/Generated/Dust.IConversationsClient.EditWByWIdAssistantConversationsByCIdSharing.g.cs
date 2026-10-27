#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Update conversation sharing<br/>
        /// Gives members of the workspace, by email, write access to a conversation, or removes it with `none`. Requires write access to the conversation. The access of the conversation's owner can't be changed.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantConversationsSharingResponse> EditWByWIdAssistantConversationsByCIdSharingAsync(
            string wId,
            string cId,

            global::Dust.PatchWAssistantConversationsSharingRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update conversation sharing<br/>
        /// Gives members of the workspace, by email, write access to a conversation, or removes it with `none`. Requires write access to the conversation. The access of the conversation's owner can't be changed.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.PatchWAssistantConversationsSharingResponse>> EditWByWIdAssistantConversationsByCIdSharingAsResponseAsync(
            string wId,
            string cId,

            global::Dust.PatchWAssistantConversationsSharingRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update conversation sharing<br/>
        /// Gives members of the workspace, by email, write access to a conversation, or removes it with `none`. Requires write access to the conversation. The access of the conversation's owner can't be changed.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="changes">
        /// A user listed more than once gets their last change.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantConversationsSharingResponse> EditWByWIdAssistantConversationsByCIdSharingAsync(
            string wId,
            string cId,
            global::System.Collections.Generic.IList<global::Dust.ConversationSharingChange> changes,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}