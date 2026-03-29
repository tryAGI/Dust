
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateToolPersonalAuthRequiredEventAuthError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServerId")]
        public string? McpServerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

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
        /// Initializes a new instance of the <see cref="PrivateToolPersonalAuthRequiredEventAuthError" /> class.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="provider"></param>
        /// <param name="scope"></param>
        /// <param name="toolName"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateToolPersonalAuthRequiredEventAuthError(
            string? mcpServerId,
            string? provider,
            string? scope,
            string? toolName,
            string? message)
        {
            this.McpServerId = mcpServerId;
            this.Provider = provider;
            this.Scope = scope;
            this.ToolName = toolName;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateToolPersonalAuthRequiredEventAuthError" /> class.
        /// </summary>
        public PrivateToolPersonalAuthRequiredEventAuthError()
        {
        }
    }
}