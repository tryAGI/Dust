#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Get a conversation credit attribution<br/>
        /// Returns the latest stable credits billed for completed messages belonging directly to a conversation, plus an additive attribution reconciled exclusively through model input rows. In-progress messages are included after they reach a terminal state.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsConsumptionResponse> GetWByWIdAssistantConversationsByCIdConsumptionAsync(
            string wId,
            string cId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a conversation credit attribution<br/>
        /// Returns the latest stable credits billed for completed messages belonging directly to a conversation, plus an additive attribution reconciled exclusively through model input rows. In-progress messages are included after they reach a terminal state.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.GetWAssistantConversationsConsumptionResponse>> GetWByWIdAssistantConversationsByCIdConsumptionAsResponseAsync(
            string wId,
            string cId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}