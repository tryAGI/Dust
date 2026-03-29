#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get the events for a conversation<br/>
        /// Get the events for a conversation in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="lastEventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task GetWByWIdAssistantConversationsByCIdEventsAsync(
            string wId,
            string cId,
            string? lastEventId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}