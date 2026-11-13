#nullable enable

namespace Dust
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// List the files in a pod<br/>
        /// List the relative paths of the files already in the pod. The response has no file bytes.<br/>
        /// The API key must be allowed to write the pod. A missing pod and a pod the key cannot<br/>
        /// write are both reported as not found.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="podId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWPodsFilesResponse> GetWByWIdPodsByPodIdFilesAsync(
            string wId,
            string podId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the files in a pod<br/>
        /// List the relative paths of the files already in the pod. The response has no file bytes.<br/>
        /// The API key must be allowed to write the pod. A missing pod and a pod the key cannot<br/>
        /// write are both reported as not found.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="podId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.GetWPodsFilesResponse>> GetWByWIdPodsByPodIdFilesAsResponseAsync(
            string wId,
            string podId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}