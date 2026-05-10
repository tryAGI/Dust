
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillSourceMetadata
    {
        /// <summary>
        /// URL of the source repository, when applicable<br/>
        /// Example: https://github.com/dust-tt/skills
        /// </summary>
        /// <example>https://github.com/dust-tt/skills</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUrl")]
        public string? RepoUrl { get; set; }

        /// <summary>
        /// Path to the source skill file<br/>
        /// Example: support/SKILL.md
        /// </summary>
        /// <example>support/SKILL.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filePath")]
        public string? FilePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillSourceMetadata" /> class.
        /// </summary>
        /// <param name="repoUrl">
        /// URL of the source repository, when applicable<br/>
        /// Example: https://github.com/dust-tt/skills
        /// </param>
        /// <param name="filePath">
        /// Path to the source skill file<br/>
        /// Example: support/SKILL.md
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillSourceMetadata(
            string? repoUrl,
            string? filePath)
        {
            this.RepoUrl = repoUrl;
            this.FilePath = filePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillSourceMetadata" /> class.
        /// </summary>
        public SkillSourceMetadata()
        {
        }

    }
}