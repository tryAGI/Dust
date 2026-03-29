
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Table
    {
        /// <summary>
        /// Name of the table<br/>
        /// Example: Roi data
        /// </summary>
        /// <example>Roi data</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Name { get; set; }

        /// <summary>
        /// Title of the table<br/>
        /// Example: ROI Data
        /// </summary>
        /// <example>ROI Data</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Unique identifier for the table<br/>
        /// Example: 1234f4567c
        /// </summary>
        /// <example>1234f4567c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// Description of the table<br/>
        /// Example: roi data for Q1
        /// </summary>
        /// <example>roi data for Q1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// MIME type of the table<br/>
        /// Example: text/csv
        /// </summary>
        /// <example>text/csv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Array of column definitions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::System.Collections.Generic.IList<global::Dust.TableSchemaItem>? Schema { get; set; }

        /// <summary>
        /// Unix timestamp of table creation/modification<br/>
        /// Example: 1732810375150L
        /// </summary>
        /// <example>1732810375150L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Array of tags associated with the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// ID of the table parent<br/>
        /// Example: 1234f4567c
        /// </summary>
        /// <example>1234f4567c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Array of parent table IDs<br/>
        /// Example: [1234f4567c]
        /// </summary>
        /// <example>[1234f4567c]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        public global::System.Collections.Generic.IList<string>? Parents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the table<br/>
        /// Example: ROI Data
        /// </param>
        /// <param name="tableId">
        /// Unique identifier for the table<br/>
        /// Example: 1234f4567c
        /// </param>
        /// <param name="description">
        /// Description of the table<br/>
        /// Example: roi data for Q1
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the table<br/>
        /// Example: text/csv
        /// </param>
        /// <param name="schema">
        /// Array of column definitions
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp of table creation/modification<br/>
        /// Example: 1732810375150L
        /// </param>
        /// <param name="tags">
        /// Array of tags associated with the table
        /// </param>
        /// <param name="parentId">
        /// ID of the table parent<br/>
        /// Example: 1234f4567c
        /// </param>
        /// <param name="parents">
        /// Array of parent table IDs<br/>
        /// Example: [1234f4567c]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Table(
            string? title,
            string? tableId,
            string? description,
            string? mimeType,
            global::System.Collections.Generic.IList<global::Dust.TableSchemaItem>? schema,
            double? timestamp,
            global::System.Collections.Generic.IList<string>? tags,
            string? parentId,
            global::System.Collections.Generic.IList<string>? parents)
        {
            this.Title = title;
            this.TableId = tableId;
            this.Description = description;
            this.MimeType = mimeType;
            this.Schema = schema;
            this.Timestamp = timestamp;
            this.Tags = tags;
            this.ParentId = parentId;
            this.Parents = parents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        public Table()
        {
        }
    }
}