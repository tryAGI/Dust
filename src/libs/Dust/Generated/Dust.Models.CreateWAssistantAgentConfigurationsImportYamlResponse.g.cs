
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantAgentConfigurationsImportYamlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfiguration")]
        public global::Dust.AgentConfiguration? AgentConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skippedActions")]
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlResponseSkippedAction>? SkippedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlResponse" /> class.
        /// </summary>
        /// <param name="agentConfiguration"></param>
        /// <param name="skippedActions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantAgentConfigurationsImportYamlResponse(
            global::Dust.AgentConfiguration? agentConfiguration,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlResponseSkippedAction>? skippedActions)
        {
            this.AgentConfiguration = agentConfiguration;
            this.SkippedActions = skippedActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlResponse" /> class.
        /// </summary>
        public CreateWAssistantAgentConfigurationsImportYamlResponse()
        {
        }
    }
}