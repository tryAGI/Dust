#nullable enable

namespace Dust
{
    public partial interface IPrivateEventsClient
    {
        /// <summary>
        /// Stream message events<br/>
        /// Stream real-time events for a specific agent message using Server-Sent Events (SSE). Only available for agent messages. This endpoint is redirected to /api/sse/ for SSE traffic routing.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Dust.PrivateAgentMessageEvent> GetWByWIdAssistantConversationsByCIdMessagesByMIdEventsAsync(
            string wId,
            string cId,
            string mId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}