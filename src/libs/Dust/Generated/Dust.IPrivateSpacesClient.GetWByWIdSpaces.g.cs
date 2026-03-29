#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// List spaces<br/>
        /// Returns all spaces in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="role"></param>
        /// <param name="kind"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesResponse3> GetWByWIdSpacesAsync(
            string wId,
            string? role = default,
            string? kind = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}