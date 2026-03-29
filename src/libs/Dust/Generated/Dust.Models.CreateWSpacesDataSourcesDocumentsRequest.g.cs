
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourcesDocumentsRequest
    {
        /// <summary>
        /// The title of the document to upsert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The MIME type of the document to upsert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// The text content of the document to upsert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A section of a document that can contain nested sections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section")]
        public global::Dust.Section? Section { get; set; }

        /// <summary>
        /// The source URL for the document to upsert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Tags to associate with the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Unix timestamp (in milliseconds) for the document (e.g. 1736365559000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// If true, a lightweight version of the document will be returned in the response (excluding the text, chunks and vectors). Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("light_document_output")]
        public bool? LightDocumentOutput { get; set; }

        /// <summary>
        /// If true, the upsert operation will be performed asynchronously.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Additional context for the upsert operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upsert_context")]
        public object? UpsertContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesDocumentsRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the document to upsert.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the document to upsert.
        /// </param>
        /// <param name="text">
        /// The text content of the document to upsert.
        /// </param>
        /// <param name="section">
        /// A section of a document that can contain nested sections
        /// </param>
        /// <param name="sourceUrl">
        /// The source URL for the document to upsert.
        /// </param>
        /// <param name="tags">
        /// Tags to associate with the document.
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp (in milliseconds) for the document (e.g. 1736365559000).
        /// </param>
        /// <param name="lightDocumentOutput">
        /// If true, a lightweight version of the document will be returned in the response (excluding the text, chunks and vectors). Defaults to false.
        /// </param>
        /// <param name="async">
        /// If true, the upsert operation will be performed asynchronously.
        /// </param>
        /// <param name="upsertContext">
        /// Additional context for the upsert operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourcesDocumentsRequest(
            string? title,
            string? mimeType,
            string? text,
            global::Dust.Section? section,
            string? sourceUrl,
            global::System.Collections.Generic.IList<string>? tags,
            double? timestamp,
            bool? lightDocumentOutput,
            bool? async,
            object? upsertContext)
        {
            this.Title = title;
            this.MimeType = mimeType;
            this.Text = text;
            this.Section = section;
            this.SourceUrl = sourceUrl;
            this.Tags = tags;
            this.Timestamp = timestamp;
            this.LightDocumentOutput = lightDocumentOutput;
            this.Async = async;
            this.UpsertContext = upsertContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesDocumentsRequest" /> class.
        /// </summary>
        public CreateWSpacesDataSourcesDocumentsRequest()
        {
        }
    }
}