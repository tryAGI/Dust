#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get events for a message<br/>
        /// Stream events for a message in the workspace identified by {wId} using Server-Sent Events (SSE).<br/>
        /// The stream starts with a `:connect` comment. Message frames carry JSON with `eventId` and `data` fields. A plain-text `data: done` frame ends the current connection; clients may reconnect with `lastEventId`.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="lastEventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Dust.GetWAssistantConversationsMessagesEventsResponse> GetWByWIdAssistantConversationsByCIdMessagesByMIdEventsAsync(
            string wId,
            string cId,
            string mId,
            string? lastEventId = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}