#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Upsert rows<br/>
        /// Upsert rows in the table identified by {tId} in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="tId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Datasource> CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdTablesByTIdRowsAsync(
            string wId,
            string spaceId,
            string dsId,
            string tId,

            global::Dust.CreateWSpacesDataSourcesTablesRowsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert rows<br/>
        /// Upsert rows in the table identified by {tId} in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="tId"></param>
        /// <param name="rows"></param>
        /// <param name="truncate">
        /// Whether to truncate existing rows
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Datasource> CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdTablesByTIdRowsAsync(
            string wId,
            string spaceId,
            string dsId,
            string tId,
            global::System.Collections.Generic.IList<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>? rows = default,
            bool? truncate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}