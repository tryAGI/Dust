
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantAgentConfigurationsResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurations")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfiguration>? AgentConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantAgentConfigurationsResponse3" /> class.
        /// </summary>
        /// <param name="agentConfigurations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantAgentConfigurationsResponse3(
            global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfiguration>? agentConfigurations)
        {
            this.AgentConfigurations = agentConfigurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantAgentConfigurationsResponse3" /> class.
        /// </summary>
        public GetWAssistantAgentConfigurationsResponse3()
        {
        }
    }
}