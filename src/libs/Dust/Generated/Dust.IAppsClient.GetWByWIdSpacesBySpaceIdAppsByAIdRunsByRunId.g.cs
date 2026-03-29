#nullable enable

namespace Dust
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Get an app run<br/>
        /// Retrieve a run for an app in the space identified by {spaceId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="aId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesAppsRunsResponse> GetWByWIdSpacesBySpaceIdAppsByAIdRunsByRunIdAsync(
            string wId,
            string spaceId,
            string aId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}