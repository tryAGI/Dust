#nullable enable

namespace Dust
{
    public partial interface IPrivateAssistantClient
    {
        /// <summary>
        /// Resolve a conversation go template draft<br/>
        /// Fetches a Contentful conversation go template by slug and returns a composer-ready draft with optional pre-uploaded attachments.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetGoTemplateDraftResponseBody> GetWByWIdAssistantGoTemplateAsync(
            string wId,
            string slug,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve a conversation go template draft<br/>
        /// Fetches a Contentful conversation go template by slug and returns a composer-ready draft with optional pre-uploaded attachments.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.GetGoTemplateDraftResponseBody>> GetWByWIdAssistantGoTemplateAsResponseAsync(
            string wId,
            string slug,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}