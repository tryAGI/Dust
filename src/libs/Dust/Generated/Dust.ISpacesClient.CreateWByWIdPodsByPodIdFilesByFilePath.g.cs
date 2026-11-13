#nullable enable

namespace Dust
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Upload a file into a pod<br/>
        /// Upload the request body as a file in the pod. `filePath` is the path inside the pod,<br/>
        /// including subfolders (`reports/q3.txt`). The body is the raw file bytes. `Content-Type`<br/>
        /// is the file type (parameters such as charset are ignored) and `Content-Length` is required.<br/>
        /// The API key must be allowed to write the pod.<br/>
        /// The path is checked with the same normalization as other file paths. A path that leaves<br/>
        /// the pod is rejected and nothing is written.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="podId"></param>
        /// <param name="filePath"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWPodsFilesResponse> CreateWByWIdPodsByPodIdFilesByFilePathAsync(
            string wId,
            string podId,
            string filePath,

            byte[] request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file into a pod<br/>
        /// Upload the request body as a file in the pod. `filePath` is the path inside the pod,<br/>
        /// including subfolders (`reports/q3.txt`). The body is the raw file bytes. `Content-Type`<br/>
        /// is the file type (parameters such as charset are ignored) and `Content-Length` is required.<br/>
        /// The API key must be allowed to write the pod.<br/>
        /// The path is checked with the same normalization as other file paths. A path that leaves<br/>
        /// the pod is rejected and nothing is written.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="podId"></param>
        /// <param name="filePath"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.CreateWPodsFilesResponse>> CreateWByWIdPodsByPodIdFilesByFilePathAsResponseAsync(
            string wId,
            string podId,
            string filePath,

            byte[] request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}