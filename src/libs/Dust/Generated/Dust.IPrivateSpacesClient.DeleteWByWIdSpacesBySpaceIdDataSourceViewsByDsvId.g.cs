#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// Delete a data source view<br/>
        /// Deletes a specific data source view.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsvId"></param>
        /// <param name="force"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdAsync(
            string wId,
            string spaceId,
            string dsvId,
            global::Dust.DeleteWSpacesDataSourceViewsForce? force = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}