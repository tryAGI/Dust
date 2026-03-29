#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Check the upsert queue status for a data source<br/>
        /// Returns the number of running document upsert workflows for this data source. This endpoint is only accessible with system API keys (e.g., from connectors).
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourcesCheckUpsertQueueResponse> GetWByWIdSpacesBySpaceIdDataSourcesByDsIdCheckUpsertQueueAsync(
            string wId,
            string spaceId,
            string dsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}