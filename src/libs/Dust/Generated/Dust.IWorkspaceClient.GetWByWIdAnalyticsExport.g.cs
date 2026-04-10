#nullable enable

namespace Dust
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Export workspace analytics as CSV<br/>
        /// Export analytics data for the workspace identified by {wId} in CSV format.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="table"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="timezone"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWByWIdAnalyticsExportAsync(
            string wId,
            global::Dust.GetWAnalyticsExportTable table,
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            string? timezone = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}