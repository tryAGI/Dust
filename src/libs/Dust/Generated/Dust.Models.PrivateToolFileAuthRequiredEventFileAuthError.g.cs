
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateToolFileAuthRequiredEventFileAuthError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionId")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateToolFileAuthRequiredEventFileAuthError" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="fileName"></param>
        /// <param name="connectionId"></param>
        /// <param name="mimeType"></param>
        /// <param name="toolName"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateToolFileAuthRequiredEventFileAuthError(
            string? fileId,
            string? fileName,
            string? connectionId,
            string? mimeType,
            string? toolName,
            string? message)
        {
            this.FileId = fileId;
            this.FileName = fileName;
            this.ConnectionId = connectionId;
            this.MimeType = mimeType;
            this.ToolName = toolName;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateToolFileAuthRequiredEventFileAuthError" /> class.
        /// </summary>
        public PrivateToolFileAuthRequiredEventFileAuthError()
        {
        }
    }
}