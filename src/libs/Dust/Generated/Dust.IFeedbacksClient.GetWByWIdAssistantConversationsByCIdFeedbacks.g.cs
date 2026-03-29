#nullable enable

namespace Dust
{
    public partial interface IFeedbacksClient
    {
        /// <summary>
        /// Get feedbacks for a conversation<br/>
        /// Retrieves all feedback entries for a specific conversation.<br/>
        /// Requires authentication and read:conversation scope.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsFeedbacksResponse> GetWByWIdAssistantConversationsByCIdFeedbacksAsync(
            string wId,
            string cId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}