#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get a conversation<br/>
        /// Get a conversation in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Conversation> GetWByWIdAssistantConversationsByCIdAsync(
            string wId,
            string cId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}