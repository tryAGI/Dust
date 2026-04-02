
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantAgentConfigurationsRequestTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindJsonConverter))]
        public global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestTag" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantAgentConfigurationsRequestTag(
            string? name,
            global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind? kind)
        {
            this.Name = name;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestTag" /> class.
        /// </summary>
        public PatchWAssistantAgentConfigurationsRequestTag()
        {
        }
    }
}