
#nullable enable

namespace Dust
{
    /// <summary>
    /// A skill attached to an agent configuration.
    /// </summary>
    public sealed partial class AgentSkill
    {
        /// <summary>
        /// Unique string identifier for the skill<br/>
        /// Example: skill_abc123
        /// </summary>
        /// <example>skill_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Name of the skill<br/>
        /// Example: Customer Support
        /// </summary>
        /// <example>Customer Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        /// <param name="sId">
        /// Unique string identifier for the skill<br/>
        /// Example: skill_abc123
        /// </param>
        /// <param name="name">
        /// Name of the skill<br/>
        /// Example: Customer Support
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSkill(
            string? sId,
            string? name)
        {
            this.SId = sId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        public AgentSkill()
        {
        }

    }
}