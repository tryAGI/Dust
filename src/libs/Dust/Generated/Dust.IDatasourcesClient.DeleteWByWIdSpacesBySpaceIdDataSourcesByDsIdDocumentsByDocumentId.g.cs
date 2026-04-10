#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Delete a document from a data source<br/>
        /// Delete a document from a data source in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.DeleteWSpacesDataSourcesDocumentsResponse> DeleteWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}