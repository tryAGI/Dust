#nullable enable

namespace Dust
{
    public partial interface IPrivateMessagesClient
    {
        /// <summary>
        /// Get a single action<br/>
        /// Retrieve a single action by its ID within an agent message, along with the message status.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="aId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsMessagesActionsResponse> GetWByWIdAssistantConversationsByCIdMessagesByMIdActionsByAIdAsync(
            string wId,
            string cId,
            string mId,
            string aId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}