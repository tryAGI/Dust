
#nullable enable

namespace Dust
{
    /// <summary>
    /// A rich mention suggestion for agents or users.
    /// </summary>
    public sealed partial class PrivateMentionSuggestion
    {
        /// <summary>
        /// Agent sId or user sId
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateMentionSuggestionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateMentionSuggestionType Type { get; set; }

        /// <summary>
        /// Display name
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
        /// Agent description or user email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the agent is a user favorite (agent mentions only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFavorite")]
        public bool? UserFavorite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateMentionSuggestion" /> class.
        /// </summary>
        /// <param name="id">
        /// Agent sId or user sId
        /// </param>
        /// <param name="type"></param>
        /// <param name="label">
        /// Display name
        /// </param>
        /// <param name="pictureUrl"></param>
        /// <param name="description">
        /// Agent description or user email
        /// </param>
        /// <param name="userFavorite">
        /// Whether the agent is a user favorite (agent mentions only)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateMentionSuggestion(
            string id,
            global::Dust.PrivateMentionSuggestionType type,
            string label,
            string pictureUrl,
            string description,
            bool? userFavorite)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PictureUrl = pictureUrl ?? throw new global::System.ArgumentNullException(nameof(pictureUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.UserFavorite = userFavorite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateMentionSuggestion" /> class.
        /// </summary>
        public PrivateMentionSuggestion()
        {
        }
    }
}