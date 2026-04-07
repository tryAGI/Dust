
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateAgentMCPActionGeneratedFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInProjectContext")]
        public bool? IsInProjectContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMCPActionGeneratedFile" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="title"></param>
        /// <param name="contentType"></param>
        /// <param name="snippet"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="isInProjectContext"></param>
        /// <param name="hidden"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateAgentMCPActionGeneratedFile(
            string? fileId,
            string? title,
            string? contentType,
            string? snippet,
            int? createdAt,
            int? updatedAt,
            bool? isInProjectContext,
            bool? hidden)
        {
            this.FileId = fileId;
            this.Title = title;
            this.ContentType = contentType;
            this.Snippet = snippet;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsInProjectContext = isInProjectContext;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMCPActionGeneratedFile" /> class.
        /// </summary>
        public PrivateAgentMCPActionGeneratedFile()
        {
        }
    }
}