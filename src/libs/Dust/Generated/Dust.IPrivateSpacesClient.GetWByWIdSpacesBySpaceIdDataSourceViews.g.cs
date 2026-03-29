#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// List data source views<br/>
        /// Returns all data source views in a specific space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="category"></param>
        /// <param name="withDetails"></param>
        /// <param name="includeEditedBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourceViewsResponse3> GetWByWIdSpacesBySpaceIdDataSourceViewsAsync(
            string wId,
            string spaceId,
            global::Dust.GetWSpacesDataSourceViewsCategory? category = default,
            global::Dust.GetWSpacesDataSourceViewsWithDetails? withDetails = default,
            global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy? includeEditedBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}