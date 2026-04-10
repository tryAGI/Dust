#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Validate an action in a conversation message<br/>
        /// Approves or rejects an action taken in a specific message in a conversation
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesValidateActionResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdValidateActionAsync(
            string wId,
            string cId,
            string mId,

            global::Dust.CreateWAssistantConversationsMessagesValidateActionRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate an action in a conversation message<br/>
        /// Approves or rejects an action taken in a specific message in a conversation
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="actionId">
        /// ID of the action to validate
        /// </param>
        /// <param name="approved">
        /// Whether the action is approved or rejected
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesValidateActionResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdValidateActionAsync(
            string wId,
            string cId,
            string mId,
            string actionId,
            bool approved,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}