
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesDataSourcesSearchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>? Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesSearchResponse" /> class.
        /// </summary>
        /// <param name="documents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesDataSourcesSearchResponse(
            global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>? documents)
        {
            this.Documents = documents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesSearchResponse" /> class.
        /// </summary>
        public GetWSpacesDataSourcesSearchResponse()
        {
        }
    }
}