#nullable enable

namespace Dust
{
    public partial interface IPrivateMessagesClient
    {
        /// <summary>
        /// Get an agent message credit attribution<br/>
        /// Returns direct and total billed credits. Run-agent tool rows combine invocation cost with the bill of their sub-agent subtree.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsMessagesConsumptionResponse> GetWByWIdAssistantConversationsByCIdMessagesByMIdConsumptionAsync(
            string wId,
            string cId,
            string mId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an agent message credit attribution<br/>
        /// Returns direct and total billed credits. Run-agent tool rows combine invocation cost with the bill of their sub-agent subtree.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.GetWAssistantConversationsMessagesConsumptionResponse>> GetWByWIdAssistantConversationsByCIdMessagesByMIdConsumptionAsResponseAsync(
            string wId,
            string cId,
            string mId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}