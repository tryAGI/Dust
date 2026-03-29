
#nullable enable

namespace Dust
{
    /// <summary>
    /// Information about the user who last edited the MCP server view
    /// </summary>
    public sealed partial class MCPServerViewEditedByUser
    {
        /// <summary>
        /// Unix timestamp of when the edit occurred<br/>
        /// Example: 1625184000
        /// </summary>
        /// <example>1625184000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("editedAt")]
        public double? EditedAt { get; set; }

        /// <summary>
        /// Full name of the editor<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// Profile image URL of the editor<br/>
        /// Example: https://example.com/profile/johndoe.jpg
        /// </summary>
        /// <example>https://example.com/profile/johndoe.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewEditedByUser" /> class.
        /// </summary>
        /// <param name="editedAt">
        /// Unix timestamp of when the edit occurred<br/>
        /// Example: 1625184000
        /// </param>
        /// <param name="fullName">
        /// Full name of the editor<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="imageUrl">
        /// Profile image URL of the editor<br/>
        /// Example: https://example.com/profile/johndoe.jpg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerViewEditedByUser(
            double? editedAt,
            string? fullName,
            string? imageUrl)
        {
            this.EditedAt = editedAt;
            this.FullName = fullName;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewEditedByUser" /> class.
        /// </summary>
        public MCPServerViewEditedByUser()
        {
        }
    }
}