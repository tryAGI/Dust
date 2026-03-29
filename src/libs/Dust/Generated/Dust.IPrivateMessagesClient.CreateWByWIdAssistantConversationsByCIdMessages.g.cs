#nullable enable

namespace Dust
{
    public partial interface IPrivateMessagesClient
    {
        /// <summary>
        /// Post a message to a conversation<br/>
        /// Post a new user message to an existing conversation, triggering agent responses.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesResponse> CreateWByWIdAssistantConversationsByCIdMessagesAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsMessagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post a message to a conversation<br/>
        /// Post a new user message to an existing conversation, triggering agent responses.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="content"></param>
        /// <param name="mentions"></param>
        /// <param name="context"></param>
        /// <param name="skipToolsValidation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesResponse> CreateWByWIdAssistantConversationsByCIdMessagesAsync(
            string wId,
            string cId,
            string content,
            global::System.Collections.Generic.IList<global::Dust.PrivateMention> mentions,
            global::Dust.CreateWAssistantConversationsMessagesRequestContext context,
            bool? skipToolsValidation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}