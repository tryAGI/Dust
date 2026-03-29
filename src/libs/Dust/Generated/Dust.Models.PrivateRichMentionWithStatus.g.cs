
#nullable enable

namespace Dust
{
    /// <summary>
    /// A rich mention with approval status, used in message responses.
    /// </summary>
    public sealed partial class PrivateRichMentionWithStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateRichMentionWithStatusTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateRichMentionWithStatusType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PictureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFavorite")]
        public bool? UserFavorite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Dismissed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateRichMentionWithStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateRichMentionWithStatusStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRichMentionWithStatus" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="description"></param>
        /// <param name="dismissed"></param>
        /// <param name="status"></param>
        /// <param name="userFavorite"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateRichMentionWithStatus(
            string id,
            global::Dust.PrivateRichMentionWithStatusType type,
            string label,
            string pictureUrl,
            string description,
            bool dismissed,
            global::Dust.PrivateRichMentionWithStatusStatus status,
            bool? userFavorite)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PictureUrl = pictureUrl ?? throw new global::System.ArgumentNullException(nameof(pictureUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.UserFavorite = userFavorite;
            this.Dismissed = dismissed;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRichMentionWithStatus" /> class.
        /// </summary>
        public PrivateRichMentionWithStatus()
        {
        }
    }
}