
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantAgentConfigurationsImportYamlRequestAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportYamlRequestAgentScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_steps_per_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxStepsPerRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VisualizationEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlRequestAgent" /> class.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="description"></param>
        /// <param name="scope"></param>
        /// <param name="maxStepsPerRun"></param>
        /// <param name="visualizationEnabled"></param>
        /// <param name="avatarUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantAgentConfigurationsImportYamlRequestAgent(
            string handle,
            string description,
            global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope scope,
            double maxStepsPerRun,
            bool visualizationEnabled,
            string? avatarUrl)
        {
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Scope = scope;
            this.AvatarUrl = avatarUrl;
            this.MaxStepsPerRun = maxStepsPerRun;
            this.VisualizationEnabled = visualizationEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlRequestAgent" /> class.
        /// </summary>
        public CreateWAssistantAgentConfigurationsImportYamlRequestAgent()
        {
        }
    }
}