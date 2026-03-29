#nullable enable

namespace Dust
{
    public partial interface IPrivateMentionsClient
    {
        /// <summary>
        /// Get mention suggestions<br/>
        /// Returns mention suggestions for the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="query"></param>
        /// <param name="select"></param>
        /// <param name="current"></param>
        /// <param name="spaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantMentionsSuggestionsResponse2> GetWByWIdAssistantMentionsSuggestionsAsync(
            string wId,
            string? query = default,
            global::Dust.GetWAssistantMentionsSuggestionsSelect? select = default,
            global::Dust.GetWAssistantMentionsSuggestionsCurrent? current = default,
            string? spaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}