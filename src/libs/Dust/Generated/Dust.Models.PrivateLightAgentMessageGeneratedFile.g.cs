
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateLightAgentMessageGeneratedFile
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
        [global::System.Text.Json.Serialization.JsonPropertyName("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessageGeneratedFile" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="title"></param>
        /// <param name="contentType"></param>
        /// <param name="publicUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentMessageGeneratedFile(
            string? fileId,
            string? title,
            string? contentType,
            string? publicUrl)
        {
            this.FileId = fileId;
            this.Title = title;
            this.ContentType = contentType;
            this.PublicUrl = publicUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessageGeneratedFile" /> class.
        /// </summary>
        public PrivateLightAgentMessageGeneratedFile()
        {
        }
    }
}