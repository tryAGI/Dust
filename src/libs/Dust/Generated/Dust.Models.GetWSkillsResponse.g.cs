
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSkillsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Dust.Skill>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSkillsResponse" /> class.
        /// </summary>
        /// <param name="skills"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSkillsResponse(
            global::System.Collections.Generic.IList<global::Dust.Skill>? skills)
        {
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSkillsResponse" /> class.
        /// </summary>
        public GetWSkillsResponse()
        {
        }
    }
}