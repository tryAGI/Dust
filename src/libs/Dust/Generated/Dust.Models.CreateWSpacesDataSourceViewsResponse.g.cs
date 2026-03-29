
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourceViewsResponse
    {
        /// <summary>
        /// A view on a data source within a space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSourceView")]
        public global::Dust.PrivateDataSourceView? DataSourceView { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourceViewsResponse" /> class.
        /// </summary>
        /// <param name="dataSourceView">
        /// A view on a data source within a space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourceViewsResponse(
            global::Dust.PrivateDataSourceView? dataSourceView)
        {
            this.DataSourceView = dataSourceView;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourceViewsResponse" /> class.
        /// </summary>
        public CreateWSpacesDataSourceViewsResponse()
        {
        }
    }
}