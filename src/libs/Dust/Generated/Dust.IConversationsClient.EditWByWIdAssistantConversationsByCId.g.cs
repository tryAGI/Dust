#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Update conversation read status<br/>
        /// Mark a conversation as read or unread in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantConversationsResponse> EditWByWIdAssistantConversationsByCIdAsync(
            string wId,
            string cId,

            global::Dust.PatchWAssistantConversationsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update conversation read status<br/>
        /// Mark a conversation as read or unread in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="read"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantConversationsResponse> EditWByWIdAssistantConversationsByCIdAsync(
            string wId,
            string cId,
            bool? read = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}