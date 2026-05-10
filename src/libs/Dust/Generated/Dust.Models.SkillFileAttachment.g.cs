
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillFileAttachment
    {
        /// <summary>
        /// Unique string identifier for the attached file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// Name of the attached file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillFileAttachment" /> class.
        /// </summary>
        /// <param name="fileId">
        /// Unique string identifier for the attached file
        /// </param>
        /// <param name="fileName">
        /// Name of the attached file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillFileAttachment(
            string? fileId,
            string? fileName)
        {
            this.FileId = fileId;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillFileAttachment" /> class.
        /// </summary>
        public SkillFileAttachment()
        {
        }

    }
}