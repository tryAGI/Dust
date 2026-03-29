
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesDataSourcesSearchResponseDocument
    {
        /// <summary>
        /// ID of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Title of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Content of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Tags of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Parents of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        public global::System.Collections.Generic.IList<string>? Parents { get; set; }

        /// <summary>
        /// Timestamp of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Data of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Score of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesSearchResponseDocument" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the document
        /// </param>
        /// <param name="title">
        /// Title of the document
        /// </param>
        /// <param name="content">
        /// Content of the document
        /// </param>
        /// <param name="tags">
        /// Tags of the document
        /// </param>
        /// <param name="parents">
        /// Parents of the document
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of the document
        /// </param>
        /// <param name="data">
        /// Data of the document
        /// </param>
        /// <param name="score">
        /// Score of the document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesDataSourcesSearchResponseDocument(
            string? id,
            string? title,
            string? content,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? parents,
            double? timestamp,
            object? data,
            double? score)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.Tags = tags;
            this.Parents = parents;
            this.Timestamp = timestamp;
            this.Data = data;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesSearchResponseDocument" /> class.
        /// </summary>
        public GetWSpacesDataSourcesSearchResponseDocument()
        {
        }
    }
}