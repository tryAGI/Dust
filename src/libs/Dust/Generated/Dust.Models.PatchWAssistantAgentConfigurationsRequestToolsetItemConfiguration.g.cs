
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration
    {
        /// <summary>
        /// Name of the MCP server to attach. Both built-in (internal) tools and remote MCP servers are supported. A remote MCP server must first be shared to a space (global or a regular space the caller can access); it is matched by its display name, which must be unambiguous within the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        public string? McpServerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration" /> class.
        /// </summary>
        /// <param name="mcpServerName">
        /// Name of the MCP server to attach. Both built-in (internal) tools and remote MCP servers are supported. A remote MCP server must first be shared to a space (global or a regular space the caller can access); it is matched by its display name, which must be unambiguous within the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration(
            string? mcpServerName)
        {
            this.McpServerName = mcpServerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration" /> class.
        /// </summary>
        public PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration()
        {
        }

    }
}