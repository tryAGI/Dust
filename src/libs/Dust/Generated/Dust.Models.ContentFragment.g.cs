
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentFragment
    {
        /// <summary>
        /// The title of the content fragment<br/>
        /// Example: My content fragment
        /// </summary>
        /// <example>My content fragment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The content of the content fragment (optional if `fileId` is set)<br/>
        /// Example: This is my content fragment extracted text
        /// </summary>
        /// <example>This is my content fragment extracted text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The content type of the content fragment (optional if `fileId` is set)<br/>
        /// Example: text/plain
        /// </summary>
        /// <example>text/plain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The URL of the content fragment<br/>
        /// Example: https://example.com/content
        /// </summary>
        /// <example>https://example.com/content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The id of the previously uploaded file (optional if `content` and `contentType` are set)<br/>
        /// Example: fil_123456
        /// </summary>
        /// <example>fil_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// The id of the content node (optional if `content` and `contentType` are set)<br/>
        /// Example: node_123456
        /// </summary>
        /// <example>node_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The id of the data source view (optional if `content` and `contentType` are set)<br/>
        /// Example: dsv_123456
        /// </summary>
        /// <example>dsv_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeDataSourceViewId")]
        public string? NodeDataSourceViewId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dust.Context? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFragment" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the content fragment<br/>
        /// Example: My content fragment
        /// </param>
        /// <param name="content">
        /// The content of the content fragment (optional if `fileId` is set)<br/>
        /// Example: This is my content fragment extracted text
        /// </param>
        /// <param name="contentType">
        /// The content type of the content fragment (optional if `fileId` is set)<br/>
        /// Example: text/plain
        /// </param>
        /// <param name="url">
        /// The URL of the content fragment<br/>
        /// Example: https://example.com/content
        /// </param>
        /// <param name="fileId">
        /// The id of the previously uploaded file (optional if `content` and `contentType` are set)<br/>
        /// Example: fil_123456
        /// </param>
        /// <param name="nodeId">
        /// The id of the content node (optional if `content` and `contentType` are set)<br/>
        /// Example: node_123456
        /// </param>
        /// <param name="nodeDataSourceViewId">
        /// The id of the data source view (optional if `content` and `contentType` are set)<br/>
        /// Example: dsv_123456
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFragment(
            string title,
            string? content,
            string? contentType,
            string? url,
            string? fileId,
            string? nodeId,
            string? nodeDataSourceViewId,
            global::Dust.Context? context)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Content = content;
            this.ContentType = contentType;
            this.Url = url;
            this.FileId = fileId;
            this.NodeId = nodeId;
            this.NodeDataSourceViewId = nodeDataSourceViewId;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFragment" /> class.
        /// </summary>
        public ContentFragment()
        {
        }
    }
}