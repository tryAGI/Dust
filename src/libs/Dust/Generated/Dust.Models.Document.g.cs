
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// Example: 3b7d9f1e5a
        /// </summary>
        /// <example>3b7d9f1e5a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_id")]
        public string? DataSourceId { get; set; }

        /// <summary>
        /// Example: 1625097600
        /// </summary>
        /// <example>1625097600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public double? Created { get; set; }

        /// <summary>
        /// Example: 2c4a6e8d0f
        /// </summary>
        /// <example>2c4a6e8d0f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Title of the document<br/>
        /// Example: Customer Support FAQ
        /// </summary>
        /// <example>Customer Support FAQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// MIME type of the table<br/>
        /// Example: text/md
        /// </summary>
        /// <example>text/md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Example: 1625097600
        /// </summary>
        /// <example>1625097600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Example: [customer_support, faq]
        /// </summary>
        /// <example>[customer_support, faq]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// ID of the document parent<br/>
        /// Example: 1234f4567c
        /// </summary>
        /// <example>1234f4567c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Example: [7b9d1f3e5a, 2c4a6e8d0f]
        /// </summary>
        /// <example>[7b9d1f3e5a, 2c4a6e8d0f]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        public global::System.Collections.Generic.IList<string>? Parents { get; set; }

        /// <summary>
        /// Example: https://example.com/support/article1
        /// </summary>
        /// <example>https://example.com/support/article1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Example: a1b2c3d4e5
        /// </summary>
        /// <example>a1b2c3d4e5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_size")]
        public double? TextSize { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_count")]
        public double? ChunkCount { get; set; }

        /// <summary>
        /// Example: [{"chunk_id":"9f1d3b5a7c","text":"This is the first chunk of the document.","embedding":[0.1,0.2,0.3,0.4]}, {"chunk_id":"4a2c6e8b0d","text":"This is the second chunk of the document.","embedding":[0.5,0.6,0.7,0.8]}]
        /// </summary>
        /// <example>[{"chunk_id":"9f1d3b5a7c","text":"This is the first chunk of the document.","embedding":[0.1,0.2,0.3,0.4]}, {"chunk_id":"4a2c6e8b0d","text":"This is the second chunk of the document.","embedding":[0.5,0.6,0.7,0.8]}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<object>? Chunks { get; set; }

        /// <summary>
        /// Example: This is the full text content of the document. It contains multiple paragraphs and covers various topics related to customer support.
        /// </summary>
        /// <example>This is the full text content of the document. It contains multiple paragraphs and covers various topics related to customer support.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        public double? TokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="dataSourceId">
        /// Example: 3b7d9f1e5a
        /// </param>
        /// <param name="created">
        /// Example: 1625097600
        /// </param>
        /// <param name="documentId">
        /// Example: 2c4a6e8d0f
        /// </param>
        /// <param name="title">
        /// Title of the document<br/>
        /// Example: Customer Support FAQ
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the table<br/>
        /// Example: text/md
        /// </param>
        /// <param name="timestamp">
        /// Example: 1625097600
        /// </param>
        /// <param name="tags">
        /// Example: [customer_support, faq]
        /// </param>
        /// <param name="parentId">
        /// ID of the document parent<br/>
        /// Example: 1234f4567c
        /// </param>
        /// <param name="parents">
        /// Example: [7b9d1f3e5a, 2c4a6e8d0f]
        /// </param>
        /// <param name="sourceUrl">
        /// Example: https://example.com/support/article1
        /// </param>
        /// <param name="hash">
        /// Example: a1b2c3d4e5
        /// </param>
        /// <param name="textSize">
        /// Example: 1024
        /// </param>
        /// <param name="chunkCount">
        /// Example: 5
        /// </param>
        /// <param name="chunks">
        /// Example: [{"chunk_id":"9f1d3b5a7c","text":"This is the first chunk of the document.","embedding":[0.1,0.2,0.3,0.4]}, {"chunk_id":"4a2c6e8b0d","text":"This is the second chunk of the document.","embedding":[0.5,0.6,0.7,0.8]}]
        /// </param>
        /// <param name="text">
        /// Example: This is the full text content of the document. It contains multiple paragraphs and covers various topics related to customer support.
        /// </param>
        /// <param name="tokenCount">
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Document(
            string? dataSourceId,
            double? created,
            string? documentId,
            string? title,
            string? mimeType,
            double? timestamp,
            global::System.Collections.Generic.IList<string>? tags,
            string? parentId,
            global::System.Collections.Generic.IList<string>? parents,
            string? sourceUrl,
            string? hash,
            double? textSize,
            double? chunkCount,
            global::System.Collections.Generic.IList<object>? chunks,
            string? text,
            double? tokenCount)
        {
            this.DataSourceId = dataSourceId;
            this.Created = created;
            this.DocumentId = documentId;
            this.Title = title;
            this.MimeType = mimeType;
            this.Timestamp = timestamp;
            this.Tags = tags;
            this.ParentId = parentId;
            this.Parents = parents;
            this.SourceUrl = sourceUrl;
            this.Hash = hash;
            this.TextSize = textSize;
            this.ChunkCount = chunkCount;
            this.Chunks = chunks;
            this.Text = text;
            this.TokenCount = tokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}