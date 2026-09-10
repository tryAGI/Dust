
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentConfigurationTag
    {
        /// <summary>
        /// Example: 3f9d1c7a5b
        /// </summary>
        /// <example>3f9d1c7a5b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Example: Support
        /// </summary>
        /// <example>Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.AgentConfigurationTagKindJsonConverter))]
        public global::Dust.AgentConfigurationTagKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigurationTag" /> class.
        /// </summary>
        /// <param name="sId">
        /// Example: 3f9d1c7a5b
        /// </param>
        /// <param name="name">
        /// Example: Support
        /// </param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigurationTag(
            string? sId,
            string? name,
            global::Dust.AgentConfigurationTagKind? kind)
        {
            this.SId = sId;
            this.Name = name;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigurationTag" /> class.
        /// </summary>
        public AgentConfigurationTag()
        {
        }

    }
}