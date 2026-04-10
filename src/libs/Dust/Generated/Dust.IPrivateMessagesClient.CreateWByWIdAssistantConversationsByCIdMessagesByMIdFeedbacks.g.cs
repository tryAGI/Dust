#nullable enable

namespace Dust
{
    public partial interface IPrivateMessagesClient
    {
        /// <summary>
        /// Submit message feedback<br/>
        /// Create or update feedback (thumbs up/down) for a specific agent message.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse2> CreateWByWIdAssistantConversationsByCIdMessagesByMIdFeedbacksAsync(
            string wId,
            string cId,
            string mId,

            global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest2 request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit message feedback<br/>
        /// Create or update feedback (thumbs up/down) for a specific agent message.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="thumbDirection"></param>
        /// <param name="feedbackContent"></param>
        /// <param name="isConversationShared"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse2> CreateWByWIdAssistantConversationsByCIdMessagesByMIdFeedbacksAsync(
            string wId,
            string cId,
            string mId,
            global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2 thumbDirection,
            string? feedbackContent = default,
            bool? isConversationShared = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}