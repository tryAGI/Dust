
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourcesTablesRequest
    {
        /// <summary>
        /// Name of the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Title of the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Unique identifier for the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// Description of the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unix timestamp (in milliseconds) for the table (e.g. 1736365559000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Tags associated with the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Reserved for internal use, should not be set. Mime type of the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the table
        /// </param>
        /// <param name="title">
        /// Title of the table
        /// </param>
        /// <param name="tableId">
        /// Unique identifier for the table
        /// </param>
        /// <param name="description">
        /// Description of the table
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp (in milliseconds) for the table (e.g. 1736365559000).
        /// </param>
        /// <param name="tags">
        /// Tags associated with the table
        /// </param>
        /// <param name="mimeType">
        /// Reserved for internal use, should not be set. Mime type of the table
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourcesTablesRequest(
            string? name,
            string? title,
            string? tableId,
            string? description,
            double? timestamp,
            global::System.Collections.Generic.IList<string>? tags,
            string? mimeType)
        {
            this.Name = name;
            this.Title = title;
            this.TableId = tableId;
            this.Description = description;
            this.Timestamp = timestamp;
            this.Tags = tags;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesRequest" /> class.
        /// </summary>
        public CreateWSpacesDataSourcesTablesRequest()
        {
        }
    }
}