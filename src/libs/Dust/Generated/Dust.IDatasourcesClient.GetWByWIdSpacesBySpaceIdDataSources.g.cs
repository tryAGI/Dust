#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Get data sources<br/>
        /// Get data sources in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourcesResponse> GetWByWIdSpacesBySpaceIdDataSourcesAsync(
            string wId,
            string spaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}