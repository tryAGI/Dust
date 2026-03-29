#nullable enable

namespace Dust
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get workspace usage data<br/>
        /// Get usage data for the workspace identified by {wId} in CSV or JSON format.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="mode"></param>
        /// <param name="format"></param>
        /// <param name="table"></param>
        /// <param name="includeInactive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWByWIdWorkspaceUsageAsync(
            string wId,
            string start,
            global::Dust.GetWWorkspaceUsageMode mode,
            global::Dust.GetWWorkspaceUsageTable table,
            string? end = default,
            global::Dust.GetWWorkspaceUsageFormat? format = default,
            bool? includeInactive = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}