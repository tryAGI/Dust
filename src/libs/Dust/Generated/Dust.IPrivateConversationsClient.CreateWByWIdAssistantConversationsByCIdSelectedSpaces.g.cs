#nullable enable

namespace Dust
{
    public partial interface IPrivateConversationsClient
    {
        /// <summary>
        /// Select Spaces for a conversation<br/>
        /// Appends regular Spaces to a conversation's explicit selected scope.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsSelectedSpacesResponse> CreateWByWIdAssistantConversationsByCIdSelectedSpacesAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsSelectedSpacesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Select Spaces for a conversation<br/>
        /// Appends regular Spaces to a conversation's explicit selected scope.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.CreateWAssistantConversationsSelectedSpacesResponse>> CreateWByWIdAssistantConversationsByCIdSelectedSpacesAsResponseAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsSelectedSpacesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Select Spaces for a conversation<br/>
        /// Appends regular Spaces to a conversation's explicit selected scope.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="mode"></param>
        /// <param name="spaceIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsSelectedSpacesResponse> CreateWByWIdAssistantConversationsByCIdSelectedSpacesAsync(
            string wId,
            string cId,
            global::System.Collections.Generic.IList<string> spaceIds,
            global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode mode = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}