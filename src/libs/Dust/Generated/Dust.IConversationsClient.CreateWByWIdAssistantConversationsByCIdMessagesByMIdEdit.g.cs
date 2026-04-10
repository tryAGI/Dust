#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Edit an existing message in a conversation
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesEditResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdEditAsync(
            string wId,
            string cId,
            string mId,

            global::Dust.CreateWAssistantConversationsMessagesEditRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an existing message in a conversation
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="content">
        /// New content for the message
        /// </param>
        /// <param name="mentions">
        /// List of agent mentions in the message
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesEditResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdEditAsync(
            string wId,
            string cId,
            string mId,
            string content,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention> mentions,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}