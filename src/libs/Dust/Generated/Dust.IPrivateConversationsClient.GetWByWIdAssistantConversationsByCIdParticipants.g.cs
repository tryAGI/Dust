#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Get conversation participants<br/>
        /// Returns the participants of a specific conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsParticipantsResponse> GetWByWIdAssistantConversationsByCIdParticipantsAsync(
            string wId,
            string cId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}