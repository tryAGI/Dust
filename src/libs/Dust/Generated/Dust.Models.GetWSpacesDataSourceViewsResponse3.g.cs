
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesDataSourceViewsResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSourceViews")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceView>? DataSourceViews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourceViewsResponse3" /> class.
        /// </summary>
        /// <param name="dataSourceViews"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesDataSourceViewsResponse3(
            global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceView>? dataSourceViews)
        {
            this.DataSourceViews = dataSourceViews;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourceViewsResponse3" /> class.
        /// </summary>
        public GetWSpacesDataSourceViewsResponse3()
        {
        }
    }
}