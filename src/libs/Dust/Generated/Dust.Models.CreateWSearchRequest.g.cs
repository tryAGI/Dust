
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSearchRequest
    {
        /// <summary>
        /// The search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// List of data source IDs to include in search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDataSources")]
        public bool? IncludeDataSources { get; set; }

        /// <summary>
        /// Type of view to filter results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewType")]
        public string? ViewType { get; set; }

        /// <summary>
        /// List of space IDs to search in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceIds")]
        public global::System.Collections.Generic.IList<string>? SpaceIds { get; set; }

        /// <summary>
        /// List of specific node IDs to search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeIds")]
        public global::System.Collections.Generic.IList<string>? NodeIds { get; set; }

        /// <summary>
        /// Whether to search source URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchSourceUrls")]
        public bool? SearchSourceUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="includeDataSources">
        /// List of data source IDs to include in search
        /// </param>
        /// <param name="viewType">
        /// Type of view to filter results
        /// </param>
        /// <param name="spaceIds">
        /// List of space IDs to search in
        /// </param>
        /// <param name="nodeIds">
        /// List of specific node IDs to search
        /// </param>
        /// <param name="searchSourceUrls">
        /// Whether to search source URLs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSearchRequest(
            string query,
            bool? includeDataSources,
            string? viewType,
            global::System.Collections.Generic.IList<string>? spaceIds,
            global::System.Collections.Generic.IList<string>? nodeIds,
            bool? searchSourceUrls)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.IncludeDataSources = includeDataSources;
            this.ViewType = viewType;
            this.SpaceIds = spaceIds;
            this.NodeIds = nodeIds;
            this.SearchSourceUrls = searchSourceUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSearchRequest" /> class.
        /// </summary>
        public CreateWSearchRequest()
        {
        }
    }
}