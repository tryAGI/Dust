
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantAgentConfigurationsRequestAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeJsonConverter))]
        public global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_steps_per_run")]
        public double? MaxStepsPerRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization_enabled")]
        public bool? VisualizationEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestAgent" /> class.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="description"></param>
        /// <param name="scope"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="maxStepsPerRun"></param>
        /// <param name="visualizationEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantAgentConfigurationsRequestAgent(
            string? handle,
            string? description,
            global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope? scope,
            string? avatarUrl,
            double? maxStepsPerRun,
            bool? visualizationEnabled)
        {
            this.Handle = handle;
            this.Description = description;
            this.Scope = scope;
            this.AvatarUrl = avatarUrl;
            this.MaxStepsPerRun = maxStepsPerRun;
            this.VisualizationEnabled = visualizationEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestAgent" /> class.
        /// </summary>
        public PatchWAssistantAgentConfigurationsRequestAgent()
        {
        }
    }
}