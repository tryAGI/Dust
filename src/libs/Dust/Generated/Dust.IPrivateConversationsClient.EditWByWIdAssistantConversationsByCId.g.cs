#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Update a conversation<br/>
        /// Update a conversation's title, mark it as read, or move it to a different space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantConversationsResponse2> EditWByWIdAssistantConversationsByCIdAsync(
            string wId,
            string cId,

            global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2, global::Dust.PatchWAssistantConversationsRequestVariant3> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a conversation<br/>
        /// Update a conversation's title, mark it as read, or move it to a different space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWAssistantConversationsResponse2> EditWByWIdAssistantConversationsByCIdAsync(
            string wId,
            string cId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}