#nullable enable

namespace Dust
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Export consumption analytics<br/>
        /// Export per-call consumption analytics for the workspace identified by {wId}.<br/>
        /// Each row represents one unit of billed credit consumption (an LLM call or a tool call).<br/>
        /// The export can be filtered by various dimensions (agents, users, API keys, groups, models, tools, skills, sources, tags).<br/>
        /// The export is limited to a maximum of 30 days per request and times out after 10 seconds: reduce the time range<br/>
        /// or apply filters to reduce the number of rows if you encounter a timeout.<br/>
        /// Results are streamed, if an error occurs, an error message is appended and the stream is closed.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWByWIdAnalyticsConsumptionExportAsync(
            string wId,

            global::Dust.CreateWAnalyticsConsumptionExportRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export consumption analytics<br/>
        /// Export per-call consumption analytics for the workspace identified by {wId}.<br/>
        /// Each row represents one unit of billed credit consumption (an LLM call or a tool call).<br/>
        /// The export can be filtered by various dimensions (agents, users, API keys, groups, models, tools, skills, sources, tags).<br/>
        /// The export is limited to a maximum of 30 days per request and times out after 10 seconds: reduce the time range<br/>
        /// or apply filters to reduce the number of rows if you encounter a timeout.<br/>
        /// Results are streamed, if an error occurs, an error message is appended and the stream is closed.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<string>> CreateWByWIdAnalyticsConsumptionExportAsResponseAsync(
            string wId,

            global::Dust.CreateWAnalyticsConsumptionExportRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export consumption analytics<br/>
        /// Export per-call consumption analytics for the workspace identified by {wId}.<br/>
        /// Each row represents one unit of billed credit consumption (an LLM call or a tool call).<br/>
        /// The export can be filtered by various dimensions (agents, users, API keys, groups, models, tools, skills, sources, tags).<br/>
        /// The export is limited to a maximum of 30 days per request and times out after 10 seconds: reduce the time range<br/>
        /// or apply filters to reduce the number of rows if you encounter a timeout.<br/>
        /// Results are streamed, if an error occurs, an error message is appended and the stream is closed.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="startDate">
        /// Start of the time range (inclusive), ISO 8601 datetime<br/>
        /// Example: 2026-01-01T00:00:00Z
        /// </param>
        /// <param name="endDate">
        /// End of the time range (exclusive), ISO 8601 datetime. Must be after startDate, at most 30 days apart.<br/>
        /// Example: 2026-01-15T00:00:00Z
        /// </param>
        /// <param name="format">
        /// Output format (defaults to csv)
        /// </param>
        /// <param name="filter">
        /// Optional dimension filters. Each key maps to an array of string identifiers to include.<br/>
        /// Each value must be at most 256 characters. The total number of values across all dimensions must not exceed 500.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWByWIdAnalyticsConsumptionExportAsync(
            string wId,
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::Dust.CreateWAnalyticsConsumptionExportRequestFormat? format = default,
            global::Dust.CreateWAnalyticsConsumptionExportRequestFilter? filter = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}