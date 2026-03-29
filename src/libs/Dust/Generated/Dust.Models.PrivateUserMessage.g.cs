
#nullable enable

namespace Dust
{
    /// <summary>
    /// A user message in a conversation.
    /// </summary>
    public sealed partial class PrivateUserMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateUserMessageTypeJsonConverter))]
        public global::Dust.PrivateUserMessageType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateUserMessageVisibilityJsonConverter))]
        public global::Dust.PrivateUserMessageVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// The user who sent the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Dust.PrivateUserMessageUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateMention>? Mentions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("richMentions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateRichMentionWithStatus>? RichMentions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Context metadata for a user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dust.PrivateUserMessageContext? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateReaction>? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserMessage" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="created"></param>
        /// <param name="version"></param>
        /// <param name="rank"></param>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="visibility"></param>
        /// <param name="user">
        /// The user who sent the message
        /// </param>
        /// <param name="mentions"></param>
        /// <param name="richMentions"></param>
        /// <param name="context">
        /// Context metadata for a user message.
        /// </param>
        /// <param name="reactions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateUserMessage(
            string sId,
            int created,
            int version,
            int rank,
            string content,
            int? id,
            global::Dust.PrivateUserMessageType type,
            global::Dust.PrivateUserMessageVisibility? visibility,
            global::Dust.PrivateUserMessageUser? user,
            global::System.Collections.Generic.IList<global::Dust.PrivateMention>? mentions,
            global::System.Collections.Generic.IList<global::Dust.PrivateRichMentionWithStatus>? richMentions,
            global::Dust.PrivateUserMessageContext? context,
            global::System.Collections.Generic.IList<global::Dust.PrivateReaction>? reactions)
        {
            this.Id = id;
            this.Type = type;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Created = created;
            this.Visibility = visibility;
            this.Version = version;
            this.Rank = rank;
            this.User = user;
            this.Mentions = mentions;
            this.RichMentions = richMentions;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Context = context;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserMessage" /> class.
        /// </summary>
        public PrivateUserMessage()
        {
        }
    }
}