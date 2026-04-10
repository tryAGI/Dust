#nullable enable

namespace Dust
{
    public partial interface IPrivateMessagesClient
    {
        /// <summary>
        /// Edit a message<br/>
        /// Edit the content and mentions of an existing user message in a conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesEditResponse2> CreateWByWIdAssistantConversationsByCIdMessagesByMIdEditAsync(
            string wId,
            string cId,
            string mId,

            global::Dust.CreateWAssistantConversationsMessagesEditRequest2 request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a message<br/>
        /// Edit the content and mentions of an existing user message in a conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="content"></param>
        /// <param name="mentions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesEditResponse2> CreateWByWIdAssistantConversationsByCIdMessagesByMIdEditAsync(
            string wId,
            string cId,
            string mId,
            string content,
            global::System.Collections.Generic.IList<global::Dust.PrivateMention> mentions,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}