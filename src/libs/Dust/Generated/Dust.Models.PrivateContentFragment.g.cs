
#nullable enable

namespace Dust
{
    /// <summary>
    /// A content fragment (file or content node attachment) in a conversation.
    /// </summary>
    public sealed partial class PrivateContentFragment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateContentFragmentTypeJsonConverter))]
        public global::Dust.PrivateContentFragmentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateContentFragmentVisibilityJsonConverter))]
        public global::Dust.PrivateContentFragmentVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// MIME type of the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dust.PrivateContentFragmentContext? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFragmentId")]
        public string? ContentFragmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFragmentVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateContentFragmentContentFragmentVersionJsonConverter))]
        public global::Dust.PrivateContentFragmentContentFragmentVersion? ContentFragmentVersion { get; set; }

        /// <summary>
        /// Whether this is a file upload or a content node reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFragmentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateContentFragmentContentFragmentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateContentFragmentContentFragmentType ContentFragmentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiredReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateContentFragmentExpiredReasonJsonConverter))]
        public global::Dust.PrivateContentFragmentExpiredReason? ExpiredReason { get; set; }

        /// <summary>
        /// Present for file content fragments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textUrl")]
        public string? TextUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textBytes")]
        public long? TextBytes { get; set; }

        /// <summary>
        /// Present for content node fragments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeDataSourceViewId")]
        public string? NodeDataSourceViewId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateContentFragment" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="title"></param>
        /// <param name="contentType">
        /// MIME type of the content
        /// </param>
        /// <param name="contentFragmentType">
        /// Whether this is a file upload or a content node reference
        /// </param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="visibility"></param>
        /// <param name="version"></param>
        /// <param name="rank"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="context"></param>
        /// <param name="contentFragmentId"></param>
        /// <param name="contentFragmentVersion"></param>
        /// <param name="expiredReason"></param>
        /// <param name="fileId">
        /// Present for file content fragments
        /// </param>
        /// <param name="snippet"></param>
        /// <param name="textUrl"></param>
        /// <param name="textBytes"></param>
        /// <param name="nodeId">
        /// Present for content node fragments
        /// </param>
        /// <param name="nodeDataSourceViewId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateContentFragment(
            string sId,
            string title,
            string contentType,
            global::Dust.PrivateContentFragmentContentFragmentType contentFragmentType,
            global::Dust.PrivateContentFragmentType type,
            int? id,
            int? created,
            global::Dust.PrivateContentFragmentVisibility? visibility,
            int? version,
            int? rank,
            string? sourceUrl,
            global::Dust.PrivateContentFragmentContext? context,
            string? contentFragmentId,
            global::Dust.PrivateContentFragmentContentFragmentVersion? contentFragmentVersion,
            global::Dust.PrivateContentFragmentExpiredReason? expiredReason,
            string? fileId,
            string? snippet,
            string? textUrl,
            long? textBytes,
            string? nodeId,
            string? nodeDataSourceViewId)
        {
            this.Type = type;
            this.Id = id;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Created = created;
            this.Visibility = visibility;
            this.Version = version;
            this.Rank = rank;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.SourceUrl = sourceUrl;
            this.Context = context;
            this.ContentFragmentId = contentFragmentId;
            this.ContentFragmentVersion = contentFragmentVersion;
            this.ContentFragmentType = contentFragmentType;
            this.ExpiredReason = expiredReason;
            this.FileId = fileId;
            this.Snippet = snippet;
            this.TextUrl = textUrl;
            this.TextBytes = textBytes;
            this.NodeId = nodeId;
            this.NodeDataSourceViewId = nodeDataSourceViewId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateContentFragment" /> class.
        /// </summary>
        public PrivateContentFragment()
        {
        }
    }
}