#nullable enable

namespace Dust
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// List apps<br/>
        /// Get all apps in the space identified by {spaceId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesAppsResponse> GetWByWIdSpacesBySpaceIdAppsAsync(
            string wId,
            string spaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}