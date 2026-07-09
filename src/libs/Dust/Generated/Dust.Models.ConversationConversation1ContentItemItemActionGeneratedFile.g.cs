
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConversation1ContentItemItemActionGeneratedFile
    {
        /// <summary>
        /// Dust file id for DB-backed files, or null for path-backed files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// Canonical scoped path for path-backed files, as surfaced by agent file system tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filePath")]
        public string? FilePath { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInProjectContext")]
        public bool? IsInProjectContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1ContentItemItemActionGeneratedFile" /> class.
        /// </summary>
        /// <param name="fileId">
        /// Dust file id for DB-backed files, or null for path-backed files.
        /// </param>
        /// <param name="filePath">
        /// Canonical scoped path for path-backed files, as surfaced by agent file system tools.
        /// </param>
        /// <param name="title"></param>
        /// <param name="contentType"></param>
        /// <param name="snippet"></param>
        /// <param name="hidden"></param>
        /// <param name="isInProjectContext"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConversation1ContentItemItemActionGeneratedFile(
            string? fileId,
            string? filePath,
            string? title,
            string? contentType,
            string? snippet,
            bool? hidden,
            bool? isInProjectContext)
        {
            this.FileId = fileId;
            this.FilePath = filePath;
            this.Title = title;
            this.ContentType = contentType;
            this.Snippet = snippet;
            this.Hidden = hidden;
            this.IsInProjectContext = isInProjectContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1ContentItemItemActionGeneratedFile" /> class.
        /// </summary>
        public ConversationConversation1ContentItemItemActionGeneratedFile()
        {
        }

    }
}