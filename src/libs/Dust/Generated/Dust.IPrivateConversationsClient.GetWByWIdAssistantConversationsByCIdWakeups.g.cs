#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// List wake-ups for a conversation<br/>
        /// Retrieve all wake-ups scheduled in a conversation (any status).
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsWakeupsResponse> GetWByWIdAssistantConversationsByCIdWakeupsAsync(
            string wId,
            string cId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}