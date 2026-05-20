
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSkillsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imported")]
        public global::System.Collections.Generic.IList<global::Dust.Skill>? Imported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public global::System.Collections.Generic.IList<global::Dust.Skill>? Updated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public global::System.Collections.Generic.IList<global::Dust.CreateWSkillsResponseSkippedItem>? Skipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsResponse" /> class.
        /// </summary>
        /// <param name="imported"></param>
        /// <param name="updated"></param>
        /// <param name="skipped"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSkillsResponse(
            global::System.Collections.Generic.IList<global::Dust.Skill>? imported,
            global::System.Collections.Generic.IList<global::Dust.Skill>? updated,
            global::System.Collections.Generic.IList<global::Dust.CreateWSkillsResponseSkippedItem>? skipped)
        {
            this.Imported = imported;
            this.Updated = updated;
            this.Skipped = skipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsResponse" /> class.
        /// </summary>
        public CreateWSkillsResponse()
        {
        }

    }
}