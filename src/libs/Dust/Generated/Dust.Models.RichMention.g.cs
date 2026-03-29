
#nullable enable

namespace Dust
{
    /// <summary>
    /// A rich mention suggestion containing detailed information about an agent or user
    /// </summary>
    public sealed partial class RichMention
    {
        /// <summary>
        /// Unique identifier for the mention (agent sId or user sId)<br/>
        /// Example: 7f3a9c2b1e
        /// </summary>
        /// <example>7f3a9c2b1e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of the mention<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.RichMentionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.RichMentionType Type { get; set; }

        /// <summary>
        /// Display label for the mention<br/>
        /// Example: My Assistant
        /// </summary>
        /// <example>My Assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// URL of the profile picture<br/>
        /// Example: https://example.com/avatar.png
        /// </summary>
        /// <example>https://example.com/avatar.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PictureUrl { get; set; }

        /// <summary>
        /// Description of the mention (agent description or user email)<br/>
        /// Example: A helpful AI assistant
        /// </summary>
        /// <example>A helpful AI assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the agent is marked as a favorite by the user (only for agent mentions)<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFavorite")]
        public bool? UserFavorite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichMention" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the mention (agent sId or user sId)<br/>
        /// Example: 7f3a9c2b1e
        /// </param>
        /// <param name="type">
        /// Type of the mention<br/>
        /// Example: agent
        /// </param>
        /// <param name="label">
        /// Display label for the mention<br/>
        /// Example: My Assistant
        /// </param>
        /// <param name="pictureUrl">
        /// URL of the profile picture<br/>
        /// Example: https://example.com/avatar.png
        /// </param>
        /// <param name="description">
        /// Description of the mention (agent description or user email)<br/>
        /// Example: A helpful AI assistant
        /// </param>
        /// <param name="userFavorite">
        /// Whether the agent is marked as a favorite by the user (only for agent mentions)<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichMention(
            string id,
            global::Dust.RichMentionType type,
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
        /// Initializes a new instance of the <see cref="RichMention" /> class.
        /// </summary>
        public RichMention()
        {
        }
    }
}