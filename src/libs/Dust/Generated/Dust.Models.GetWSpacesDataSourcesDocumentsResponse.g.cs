
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesDataSourcesDocumentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Dust.Document? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesDocumentsResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesDataSourcesDocumentsResponse(
            global::Dust.Document? document)
        {
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesDocumentsResponse" /> class.
        /// </summary>
        public GetWSpacesDataSourcesDocumentsResponse()
        {
        }
    }
}