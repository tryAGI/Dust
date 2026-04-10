#nullable enable

namespace Dust
{
    public partial interface IMentionsClient
    {
        /// <summary>
        /// Get mention suggestions for a conversation<br/>
        /// Get suggestions for mentions (agents and users) based on a query string, scoped to a specific conversation.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="query"></param>
        /// <param name="select"></param>
        /// <param name="current"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsMentionsSuggestionsResponse> GetWByWIdAssistantConversationsByCIdMentionsSuggestionsAsync(
            string wId,
            string cId,
            string query,
            global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>? select = default,
            bool? current = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}