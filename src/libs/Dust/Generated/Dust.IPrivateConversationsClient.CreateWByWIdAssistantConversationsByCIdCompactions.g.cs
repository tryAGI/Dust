#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Compact a conversation<br/>
        /// Trigger compaction of a conversation, summarizing older messages into a compaction message. Requires a model to use for summary generation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsCompactionsResponse> CreateWByWIdAssistantConversationsByCIdCompactionsAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsCompactionsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compact a conversation<br/>
        /// Trigger compaction of a conversation, summarizing older messages into a compaction message. Requires a model to use for summary generation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsCompactionsResponse> CreateWByWIdAssistantConversationsByCIdCompactionsAsync(
            string wId,
            string cId,
            global::Dust.CreateWAssistantConversationsCompactionsRequestModel model,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}