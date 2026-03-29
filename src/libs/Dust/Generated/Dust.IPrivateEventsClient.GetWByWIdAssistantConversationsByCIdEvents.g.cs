#nullable enable

namespace Dust
{
    public partial interface IPrivateEventsClient
    {
        /// <summary>
        /// Stream conversation events<br/>
        /// Stream real-time conversation events using Server-Sent Events (SSE). This endpoint is redirected to /api/sse/ for SSE traffic routing.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Dust.PrivateConversationEvent> GetWByWIdAssistantConversationsByCIdEventsAsync(
            string wId,
            string cId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}