
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantAgentConfigurationsResponse
    {
        /// <summary>
        /// Agent configuration as returned by the private list endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfiguration")]
        public global::Dust.PrivateLightAgentConfiguration? AgentConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsResponse" /> class.
        /// </summary>
        /// <param name="agentConfiguration">
        /// Agent configuration as returned by the private list endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantAgentConfigurationsResponse(
            global::Dust.PrivateLightAgentConfiguration? agentConfiguration)
        {
            this.AgentConfiguration = agentConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsResponse" /> class.
        /// </summary>
        public CreateWAssistantAgentConfigurationsResponse()
        {
        }
    }
}