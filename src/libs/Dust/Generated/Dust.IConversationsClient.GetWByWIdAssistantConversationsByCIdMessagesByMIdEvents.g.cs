#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get events for a message<br/>
        /// Get events for a message in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="lastEventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsMessagesEventsResponse> GetWByWIdAssistantConversationsByCIdMessagesByMIdEventsAsync(
            string wId,
            string cId,
            string mId,
            string? lastEventId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}