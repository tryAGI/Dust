
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourcesDocumentsParentsRequest
    {
        /// <summary>
        /// Direct parent ID of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Document and ancestor ids, with the following convention: parents[0] === documentId, parents[1] === parentId, and then ancestors ids in order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        public global::System.Collections.Generic.IList<string>? Parents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesDocumentsParentsRequest" /> class.
        /// </summary>
        /// <param name="parentId">
        /// Direct parent ID of the document
        /// </param>
        /// <param name="parents">
        /// Document and ancestor ids, with the following convention: parents[0] === documentId, parents[1] === parentId, and then ancestors ids in order
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourcesDocumentsParentsRequest(
            string? parentId,
            global::System.Collections.Generic.IList<string>? parents)
        {
            this.ParentId = parentId;
            this.Parents = parents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesDocumentsParentsRequest" /> class.
        /// </summary>
        public CreateWSpacesDataSourcesDocumentsParentsRequest()
        {
        }
    }
}