#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// List conversations<br/>
        /// Retrieve a paginated list of conversations for the authenticated user in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWAssistantConversationsResponse2> GetWByWIdAssistantConversationsAsync(
            string wId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}