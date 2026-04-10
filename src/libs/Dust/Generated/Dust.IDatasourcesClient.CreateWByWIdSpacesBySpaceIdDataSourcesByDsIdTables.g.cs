#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Upsert a table<br/>
        /// Upsert a table in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Table> CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdTablesAsync(
            string wId,
            string spaceId,
            string dsId,

            global::Dust.CreateWSpacesDataSourcesTablesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert a table<br/>
        /// Upsert a table in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="name">
        /// Name of the table
        /// </param>
        /// <param name="title">
        /// Title of the table
        /// </param>
        /// <param name="tableId">
        /// Unique identifier for the table
        /// </param>
        /// <param name="description">
        /// Description of the table
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp (in milliseconds) for the table (e.g. 1736365559000).
        /// </param>
        /// <param name="tags">
        /// Tags associated with the table
        /// </param>
        /// <param name="mimeType">
        /// Reserved for internal use, should not be set. Mime type of the table
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Table> CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdTablesAsync(
            string wId,
            string spaceId,
            string dsId,
            string? name = default,
            string? title = default,
            string? tableId = default,
            string? description = default,
            double? timestamp = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? mimeType = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}