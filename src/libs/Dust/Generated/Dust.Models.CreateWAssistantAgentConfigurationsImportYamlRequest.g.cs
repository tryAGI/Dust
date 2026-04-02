
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantAgentConfigurationsImportYamlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestAgent Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestGenerationSettings GenerationSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestTag> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestEditor> Editors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItem> Toolset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlRequest" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="instructions"></param>
        /// <param name="generationSettings"></param>
        /// <param name="tags"></param>
        /// <param name="editors"></param>
        /// <param name="toolset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantAgentConfigurationsImportYamlRequest(
            global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestAgent agent,
            string instructions,
            global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestGenerationSettings generationSettings,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestTag> tags,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestEditor> editors,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItem> toolset)
        {
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.GenerationSettings = generationSettings ?? throw new global::System.ArgumentNullException(nameof(generationSettings));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Editors = editors ?? throw new global::System.ArgumentNullException(nameof(editors));
            this.Toolset = toolset ?? throw new global::System.ArgumentNullException(nameof(toolset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantAgentConfigurationsImportYamlRequest" /> class.
        /// </summary>
        public CreateWAssistantAgentConfigurationsImportYamlRequest()
        {
        }
    }
}