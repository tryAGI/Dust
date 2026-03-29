#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Update the parents of a document<br/>
        /// Update the parents of a document in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,

            global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the parents of a document<br/>
        /// Update the parents of a document in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="parentId">
        /// Direct parent ID of the document
        /// </param>
        /// <param name="parents">
        /// Document and ancestor ids, with the following convention: parents[0] === documentId, parents[1] === parentId, and then ancestors ids in order
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,
            string? parentId = default,
            global::System.Collections.Generic.IList<string>? parents = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}