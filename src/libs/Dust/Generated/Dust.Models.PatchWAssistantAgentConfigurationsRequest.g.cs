
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantAgentConfigurationsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFavorite")]
        public bool? UserFavorite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Dust.PatchWAssistantAgentConfigurationsRequestAgent? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_settings")]
        public global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings? GenerationSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editors")]
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestEditor>? Editors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolset")]
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>? Toolset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequest" /> class.
        /// </summary>
        /// <param name="userFavorite"></param>
        /// <param name="agent"></param>
        /// <param name="instructions"></param>
        /// <param name="generationSettings"></param>
        /// <param name="tags"></param>
        /// <param name="editors"></param>
        /// <param name="toolset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantAgentConfigurationsRequest(
            bool? userFavorite,
            global::Dust.PatchWAssistantAgentConfigurationsRequestAgent? agent,
            string? instructions,
            global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings? generationSettings,
            global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>? tags,
            global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestEditor>? editors,
            global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>? toolset)
        {
            this.UserFavorite = userFavorite;
            this.Agent = agent;
            this.Instructions = instructions;
            this.GenerationSettings = generationSettings;
            this.Tags = tags;
            this.Editors = editors;
            this.Toolset = toolset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequest" /> class.
        /// </summary>
        public PatchWAssistantAgentConfigurationsRequest()
        {
        }
    }
}