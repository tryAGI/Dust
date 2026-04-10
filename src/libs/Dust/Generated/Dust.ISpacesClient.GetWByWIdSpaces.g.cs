#nullable enable

namespace Dust
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// List available spaces.<br/>
        /// Retrieves a list of accessible spaces for the authenticated workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesResponse> GetWByWIdSpacesAsync(
            string wId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}