
#nullable enable

namespace Dust
{
    /// <summary>
    /// A section of a document that can contain nested sections
    /// </summary>
    public sealed partial class Section
    {
        /// <summary>
        /// Optional prefix text for the section
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Optional content text for the section
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Array of nested sections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        public global::System.Collections.Generic.IList<global::Dust.Section>? Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        /// <param name="prefix">
        /// Optional prefix text for the section
        /// </param>
        /// <param name="content">
        /// Optional content text for the section
        /// </param>
        /// <param name="sections">
        /// Array of nested sections
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Section(
            string? prefix,
            string? content,
            global::System.Collections.Generic.IList<global::Dust.Section>? sections)
        {
            this.Prefix = prefix;
            this.Content = content;
            this.Sections = sections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        public Section()
        {
        }
    }
}