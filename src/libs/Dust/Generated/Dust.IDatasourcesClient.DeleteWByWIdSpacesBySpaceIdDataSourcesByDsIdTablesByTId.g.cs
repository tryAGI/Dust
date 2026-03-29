#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Delete a table<br/>
        /// Delete a table in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="tId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWByWIdSpacesBySpaceIdDataSourcesByDsIdTablesByTIdAsync(
            string wId,
            string spaceId,
            string dsId,
            string tId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}