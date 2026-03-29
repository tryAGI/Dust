#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// Get a space<br/>
        /// Returns the details of a specific space including categories, members, and permissions.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="includeAllMembers"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesResponse2> GetWByWIdSpacesBySpaceIdAsync(
            string wId,
            string spaceId,
            global::Dust.GetWSpacesIncludeAllMembers? includeAllMembers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}