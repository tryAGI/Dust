
#nullable enable

namespace Dust
{
    /// <summary>
    /// The file open in the app hosting Dust when sending the message, e.g. `Budget.xlsx` in Excel.
    /// </summary>
    public sealed partial class ContextHostDocument
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The http(s) link of the file, e.g. on SharePoint. Absent for a file on the user's computer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextHostDocument" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url">
        /// The http(s) link of the file, e.g. on SharePoint. Absent for a file on the user's computer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextHostDocument(
            string name,
            string? url)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextHostDocument" /> class.
        /// </summary>
        public ContextHostDocument()
        {
        }

    }
}