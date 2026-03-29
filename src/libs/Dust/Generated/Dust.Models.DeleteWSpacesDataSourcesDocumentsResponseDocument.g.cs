
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteWSpacesDataSourcesDocumentsResponseDocument
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWSpacesDataSourcesDocumentsResponseDocument" /> class.
        /// </summary>
        /// <param name="documentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWSpacesDataSourcesDocumentsResponseDocument(
            string? documentId)
        {
            this.DocumentId = documentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWSpacesDataSourcesDocumentsResponseDocument" /> class.
        /// </summary>
        public DeleteWSpacesDataSourcesDocumentsResponseDocument()
        {
        }
    }
}