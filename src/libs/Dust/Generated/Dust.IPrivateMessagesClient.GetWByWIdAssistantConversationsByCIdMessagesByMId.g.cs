#nullable enable

namespace Dust
{
    public partial interface IPrivateMessagesClient
    {
        /// <summary>
        /// Get a message<br/>
        /// Retrieve a specific message by its ID within a conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsMessagesResponse> GetWByWIdAssistantConversationsByCIdMessagesByMIdAsync(
            string wId,
            string cId,
            string mId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}