#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get a conversation<br/>
        /// Get a conversation in the workspace identified by {wId}. Supports optional pagination of message content via limit and lastValue query parameters.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="limit"></param>
        /// <param name="lastValue"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Conversation> GetWByWIdAssistantConversationsByCIdAsync(
            string wId,
            string cId,
            int? limit = default,
            string? lastValue = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}