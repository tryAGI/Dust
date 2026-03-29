#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Delete or leave a conversation<br/>
        /// Delete a conversation or leave it if it is shared.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWByWIdAssistantConversationsByCIdAsync(
            string wId,
            string cId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}