#nullable enable

namespace Dust
{
    public partial interface IPrivateAnalyticsClient
    {
        /// <summary>
        /// List consumption analytics facets<br/>
        /// Lists current workspace entities and historical indexed values present in the selected period for each consumption dimension. A facet is disabled when it has no indexed document in that period after applying every active filter except the facet's own dimension.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAnalyticsConsumptionFacetsResponse> CreateWByWIdAnalyticsConsumptionFacetsAsync(
            string wId,

            global::Dust.CreateWAnalyticsConsumptionFacetsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List consumption analytics facets<br/>
        /// Lists current workspace entities and historical indexed values present in the selected period for each consumption dimension. A facet is disabled when it has no indexed document in that period after applying every active filter except the facet's own dimension.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.CreateWAnalyticsConsumptionFacetsResponse>> CreateWByWIdAnalyticsConsumptionFacetsAsResponseAsync(
            string wId,

            global::Dust.CreateWAnalyticsConsumptionFacetsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List consumption analytics facets<br/>
        /// Lists current workspace entities and historical indexed values present in the selected period for each consumption dimension. A facet is disabled when it has no indexed document in that period after applying every active filter except the facet's own dimension.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="period">
        /// Default Value: cycle
        /// </param>
        /// <param name="days">
        /// Default Value: 30
        /// </param>
        /// <param name="filter">
        /// Map of consumption dimensions to selected values.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAnalyticsConsumptionFacetsResponse> CreateWByWIdAnalyticsConsumptionFacetsAsync(
            string wId,
            global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod? period = default,
            int? days = default,
            global::Dust.CreateWAnalyticsConsumptionFacetsRequestFilter? filter = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}