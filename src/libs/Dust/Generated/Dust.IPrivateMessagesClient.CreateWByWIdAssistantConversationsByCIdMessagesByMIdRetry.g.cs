#nullable enable

namespace Dust
{
    public partial interface IPrivateMessagesClient
    {
        /// <summary>
        /// Retry an agent message<br/>
        /// Retry generating an agent message response, optionally retrying only blocked actions.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesRetryResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdRetryAsync(
            string wId,
            string cId,
            string mId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}