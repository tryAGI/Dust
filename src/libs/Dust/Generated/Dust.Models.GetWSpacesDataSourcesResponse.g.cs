
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesDataSourcesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_sources")]
        public global::System.Collections.Generic.IList<global::Dust.Datasource>? DataSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesResponse" /> class.
        /// </summary>
        /// <param name="dataSources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesDataSourcesResponse(
            global::System.Collections.Generic.IList<global::Dust.Datasource>? dataSources)
        {
            this.DataSources = dataSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesResponse" /> class.
        /// </summary>
        public GetWSpacesDataSourcesResponse()
        {
        }
    }
}