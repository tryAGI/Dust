
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSearchToolsUploadRequest
    {
        /// <summary>
        /// The MCP server view ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverViewId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerViewId { get; set; }

        /// <summary>
        /// The external ID of the file in the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Optional conversation ID for context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Optional name of the MCP server (e.g., "Notion", "GitHub")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverName")]
        public string? ServerName { get; set; }

        /// <summary>
        /// Optional icon identifier for the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverIcon")]
        public string? ServerIcon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSearchToolsUploadRequest" /> class.
        /// </summary>
        /// <param name="serverViewId">
        /// The MCP server view ID
        /// </param>
        /// <param name="externalId">
        /// The external ID of the file in the tool
        /// </param>
        /// <param name="conversationId">
        /// Optional conversation ID for context
        /// </param>
        /// <param name="serverName">
        /// Optional name of the MCP server (e.g., "Notion", "GitHub")
        /// </param>
        /// <param name="serverIcon">
        /// Optional icon identifier for the MCP server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSearchToolsUploadRequest(
            string serverViewId,
            string externalId,
            string? conversationId,
            string? serverName,
            string? serverIcon)
        {
            this.ServerViewId = serverViewId ?? throw new global::System.ArgumentNullException(nameof(serverViewId));
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
            this.ConversationId = conversationId;
            this.ServerName = serverName;
            this.ServerIcon = serverIcon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSearchToolsUploadRequest" /> class.
        /// </summary>
        public CreateWSearchToolsUploadRequest()
        {
        }
    }
}