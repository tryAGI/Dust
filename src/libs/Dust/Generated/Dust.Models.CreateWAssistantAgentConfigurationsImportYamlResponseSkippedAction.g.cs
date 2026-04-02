
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantAgentConfigurationsImportYamlResponseSkippedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlResponseSkippedAction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantAgentConfigurationsImportYamlResponseSkippedAction(
            string? name,
            string? reason)
        {
            this.Name = name;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlResponseSkippedAction" /> class.
        /// </summary>
        public CreateWAssistantAgentConfigurationsImportYamlResponseSkippedAction()
        {
        }
    }
}