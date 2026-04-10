#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Answer a user question in a conversation message<br/>
        /// Submits an answer to a question asked by an agent in a specific message
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdAnswerQuestionAsync(
            string wId,
            string cId,
            string mId,

            global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Answer a user question in a conversation message<br/>
        /// Submits an answer to a question asked by an agent in a specific message
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mId"></param>
        /// <param name="actionId">
        /// ID of the action to answer
        /// </param>
        /// <param name="answer"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionResponse> CreateWByWIdAssistantConversationsByCIdMessagesByMIdAnswerQuestionAsync(
            string wId,
            string cId,
            string mId,
            string actionId,
            global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer answer,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}