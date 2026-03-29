#nullable enable

namespace Dust
{
    public partial interface IFeedbacksClient
    {
        /// <summary>
        /// Submit feedback for a specific message in a conversation<br/>
        /// Submit user feedback (thumbs up/down) for a specific message in a conversation.<br/>
        /// Requires authentication and update:conversation scope.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdFeedbacksAsync(
            string wId,
            string cId,
            string mId,

            global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit feedback for a specific message in a conversation<br/>
        /// Submit user feedback (thumbs up/down) for a specific message in a conversation.<br/>
        /// Requires authentication and update:conversation scope.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="thumbDirection">
        /// Direction of the thumb feedback
        /// </param>
        /// <param name="feedbackContent">
        /// Optional feedback text content
        /// </param>
        /// <param name="isConversationShared">
        /// Whether the conversation is shared
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdFeedbacksAsync(
            string wId,
            string cId,
            string mId,
            global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection thumbDirection,
            string? feedbackContent = default,
            bool? isConversationShared = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}