
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantAgentConfigurationsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfiguration")]
        public global::Dust.AgentConfiguration? AgentConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantAgentConfigurationsResponse2" /> class.
        /// </summary>
        /// <param name="agentConfiguration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantAgentConfigurationsResponse2(
            global::Dust.AgentConfiguration? agentConfiguration)
        {
            this.AgentConfiguration = agentConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantAgentConfigurationsResponse2" /> class.
        /// </summary>
        public GetWAssistantAgentConfigurationsResponse2()
        {
        }
    }
}