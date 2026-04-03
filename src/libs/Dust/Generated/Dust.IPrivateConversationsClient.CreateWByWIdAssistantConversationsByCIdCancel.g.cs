#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Cancel message generation<br/>
        /// Cancels the generation of messages in a conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsCancelResponse2> CreateWByWIdAssistantConversationsByCIdCancelAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsCancelRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel message generation<br/>
        /// Cancels the generation of messages in a conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="action"></param>
        /// <param name="messageIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsCancelResponse2> CreateWByWIdAssistantConversationsByCIdCancelAsync(
            string wId,
            string cId,
            global::Dust.CreateWAssistantConversationsCancelRequestAction action,
            global::System.Collections.Generic.IList<string> messageIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}