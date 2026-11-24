#nullable enable

namespace Dust
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Export the list of pods<br/>
        /// Export every pod of the workspace identified by {wId}, restricted and archived ones<br/>
        /// included, in CSV or JSON format. Deleted pods are not listed. Use the pod ID to map the `spaceId` of other<br/>
        /// exports (such as the `messages` analytics table) to the pod name and description.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWByWIdPodsExportAsTextAsync(
            string wId,
            global::Dust.GetWPodsExportFormat? format = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export the list of pods<br/>
        /// Export every pod of the workspace identified by {wId}, restricted and archived ones<br/>
        /// included, in CSV or JSON format. Deleted pods are not listed. Use the pod ID to map the `spaceId` of other<br/>
        /// exports (such as the `messages` analytics table) to the pod name and description.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<string>> GetWByWIdPodsExportAsTextAsResponseAsync(
            string wId,
            global::Dust.GetWPodsExportFormat? format = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}