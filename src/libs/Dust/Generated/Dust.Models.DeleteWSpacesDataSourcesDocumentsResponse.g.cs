
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteWSpacesDataSourcesDocumentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Dust.DeleteWSpacesDataSourcesDocumentsResponseDocument? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWSpacesDataSourcesDocumentsResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWSpacesDataSourcesDocumentsResponse(
            global::Dust.DeleteWSpacesDataSourcesDocumentsResponseDocument? document)
        {
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWSpacesDataSourcesDocumentsResponse" /> class.
        /// </summary>
        public DeleteWSpacesDataSourcesDocumentsResponse()
        {
        }
    }
}