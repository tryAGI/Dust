
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesDataSourceViewsResponse
    {
        /// <summary>
        /// A view on a data source within a space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSourceView")]
        public global::Dust.PrivateDataSourceView? DataSourceView { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector")]
        public object? Connector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesDataSourceViewsResponse" /> class.
        /// </summary>
        /// <param name="dataSourceView">
        /// A view on a data source within a space.
        /// </param>
        /// <param name="connector"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesDataSourceViewsResponse(
            global::Dust.PrivateDataSourceView? dataSourceView,
            object? connector)
        {
            this.DataSourceView = dataSourceView;
            this.Connector = connector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesDataSourceViewsResponse" /> class.
        /// </summary>
        public PatchWSpacesDataSourceViewsResponse()
        {
        }
    }
}