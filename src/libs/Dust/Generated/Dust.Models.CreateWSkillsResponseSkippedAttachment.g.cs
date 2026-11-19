
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWSkillsResponseSkippedAttachment
    {
        /// <summary>
        /// Name of the skill the file belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Path of the file relative to the skill directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsResponseSkippedAttachment" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the skill the file belongs to.
        /// </param>
        /// <param name="path">
        /// Path of the file relative to the skill directory.
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSkillsResponseSkippedAttachment(
            string? name,
            string? path,
            string? message)
        {
            this.Name = name;
            this.Path = path;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsResponseSkippedAttachment" /> class.
        /// </summary>
        public CreateWSkillsResponseSkippedAttachment()
        {
        }

    }
}