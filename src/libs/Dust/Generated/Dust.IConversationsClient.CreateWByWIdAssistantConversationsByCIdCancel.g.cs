#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Cancel message generation in a conversation
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsCancelResponse> CreateWByWIdAssistantConversationsByCIdCancelAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsCancelRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel message generation in a conversation
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="messageIds">
        /// List of message IDs to cancel generation for
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsCancelResponse> CreateWByWIdAssistantConversationsByCIdCancelAsync(
            string wId,
            string cId,
            global::System.Collections.Generic.IList<string> messageIds,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}