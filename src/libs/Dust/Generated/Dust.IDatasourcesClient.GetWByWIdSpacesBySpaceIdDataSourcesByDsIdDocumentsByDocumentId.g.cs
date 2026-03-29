#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Retrieve a document from a data source<br/>
        /// Retrieve a document from a data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourcesDocumentsResponse> GetWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}