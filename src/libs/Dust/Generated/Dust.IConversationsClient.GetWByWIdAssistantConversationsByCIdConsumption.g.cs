#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get conversation consumption<br/>
        /// Get the same credit breakdown as the conversation consumption view for a conversation<br/>
        /// the caller can read. Returns stable billed credits for terminal agent messages, including<br/>
        /// superseded message versions and accessible recursively spawned run-agent conversations.<br/>
        /// In-progress messages are excluded until they reach a terminal state.<br/>
        /// Details use each billed message's newest complete stored attribution. They are null when<br/>
        /// no messages have positive billed credits or any billed message lacks complete attribution.<br/>
        /// Agent work and tool attributions partition the bill. Models and agents are alternative<br/>
        /// groupings of that bill, not additional charges. This endpoint does not return token counts<br/>
        /// or a cached-versus-uncached input breakdown.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.ConversationConsumption> GetWByWIdAssistantConversationsByCIdConsumptionAsync(
            string wId,
            string cId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get conversation consumption<br/>
        /// Get the same credit breakdown as the conversation consumption view for a conversation<br/>
        /// the caller can read. Returns stable billed credits for terminal agent messages, including<br/>
        /// superseded message versions and accessible recursively spawned run-agent conversations.<br/>
        /// In-progress messages are excluded until they reach a terminal state.<br/>
        /// Details use each billed message's newest complete stored attribution. They are null when<br/>
        /// no messages have positive billed credits or any billed message lacks complete attribution.<br/>
        /// Agent work and tool attributions partition the bill. Models and agents are alternative<br/>
        /// groupings of that bill, not additional charges. This endpoint does not return token counts<br/>
        /// or a cached-versus-uncached input breakdown.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.ConversationConsumption>> GetWByWIdAssistantConversationsByCIdConsumptionAsResponseAsync(
            string wId,
            string cId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}