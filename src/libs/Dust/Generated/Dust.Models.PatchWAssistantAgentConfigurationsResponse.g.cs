
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantAgentConfigurationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfiguration")]
        public global::Dust.AgentConfiguration? AgentConfiguration { get; set; }

        /// <summary>
        /// Toolset entries that could not be applied (e.g. the referenced MCP server was not found, is not shared to an accessible space, or the name was ambiguous). The request still succeeds; inspect this list to confirm every intended tool was attached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skippedActions")]
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>? SkippedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsResponse" /> class.
        /// </summary>
        /// <param name="agentConfiguration"></param>
        /// <param name="skippedActions">
        /// Toolset entries that could not be applied (e.g. the referenced MCP server was not found, is not shared to an accessible space, or the name was ambiguous). The request still succeeds; inspect this list to confirm every intended tool was attached.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantAgentConfigurationsResponse(
            global::Dust.AgentConfiguration? agentConfiguration,
            global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>? skippedActions)
        {
            this.AgentConfiguration = agentConfiguration;
            this.SkippedActions = skippedActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsResponse" /> class.
        /// </summary>
        public PatchWAssistantAgentConfigurationsResponse()
        {
        }

    }
}