#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Get a row<br/>
        /// Get a row in the table identified by {tId} in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="tId"></param>
        /// <param name="rId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Datasource> GetWByWIdSpacesBySpaceIdDataSourcesByDsIdTablesByTIdRowsByRIdAsync(
            string wId,
            string spaceId,
            string dsId,
            string tId,
            string rId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}