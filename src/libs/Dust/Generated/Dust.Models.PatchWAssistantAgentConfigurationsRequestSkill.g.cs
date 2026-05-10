
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantAgentConfigurationsRequestSkill
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestSkill" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantAgentConfigurationsRequestSkill(
            string sId,
            string name)
        {
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantAgentConfigurationsRequestSkill" /> class.
        /// </summary>
        public PatchWAssistantAgentConfigurationsRequestSkill()
        {
        }

    }
}