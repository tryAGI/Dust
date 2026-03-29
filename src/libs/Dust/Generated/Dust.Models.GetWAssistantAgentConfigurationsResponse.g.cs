
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantAgentConfigurationsResponse
    {
        /// <summary>
        /// Array of agent configurations, optionally including lastAuthors if withAuthors=true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurations")]
        public global::System.Collections.Generic.IList<global::Dust.AgentConfiguration>? AgentConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantAgentConfigurationsResponse" /> class.
        /// </summary>
        /// <param name="agentConfigurations">
        /// Array of agent configurations, optionally including lastAuthors if withAuthors=true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantAgentConfigurationsResponse(
            global::System.Collections.Generic.IList<global::Dust.AgentConfiguration>? agentConfigurations)
        {
            this.AgentConfigurations = agentConfigurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantAgentConfigurationsResponse" /> class.
        /// </summary>
        public GetWAssistantAgentConfigurationsResponse()
        {
        }
    }
}