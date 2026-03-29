
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConversation1ContentItemItem
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Unique string identifier for the message<br/>
        /// Example: 9e7d5c3a1f
        /// </summary>
        /// <example>9e7d5c3a1f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Type of the message<br/>
        /// Example: human
        /// </summary>
        /// <example>human</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Visibility setting of the message<br/>
        /// Example: visible
        /// </summary>
        /// <example>visible</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Example: 1625097700
        /// </summary>
        /// <example>1625097700</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Dust.User? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        public global::System.Collections.Generic.IList<global::Dust.Mention>? Mentions { get; set; }

        /// <summary>
        /// Content of the message<br/>
        /// Example: Hello, I need help with my order.
        /// </summary>
        /// <example>Hello, I need help with my order.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dust.Context? Context { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessageId")]
        public int? AgentMessageId { get; set; }

        /// <summary>
        /// ID of the parent message<br/>
        /// Example: 2b8e4f6a0c
        /// </summary>
        /// <example>2b8e4f6a0c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentMessageId")]
        public string? ParentMessageId { get; set; }

        /// <summary>
        /// Status of the message<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public byte[]? Actions { get; set; }

        /// <summary>
        /// Chain of thought for the message<br/>
        /// Example: The user is asking about their order. I should first greet them and then ask for their order number.
        /// </summary>
        /// <example>The user is asking about their order. I should first greet them and then ask for their order number.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainOfThought")]
        public string? ChainOfThought { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawContents")]
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemRawContent>? RawContents { get; set; }

        /// <summary>
        /// Error message, if any<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Dust.AgentConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1ContentItemItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the message<br/>
        /// Example: 9e7d5c3a1f
        /// </param>
        /// <param name="type">
        /// Type of the message<br/>
        /// Example: human
        /// </param>
        /// <param name="visibility">
        /// Visibility setting of the message<br/>
        /// Example: visible
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="created">
        /// Example: 1625097700
        /// </param>
        /// <param name="user"></param>
        /// <param name="mentions"></param>
        /// <param name="content">
        /// Content of the message<br/>
        /// Example: Hello, I need help with my order.
        /// </param>
        /// <param name="context"></param>
        /// <param name="agentMessageId">
        /// Example: 1
        /// </param>
        /// <param name="parentMessageId">
        /// ID of the parent message<br/>
        /// Example: 2b8e4f6a0c
        /// </param>
        /// <param name="status">
        /// Status of the message<br/>
        /// Example: completed
        /// </param>
        /// <param name="actions">
        /// Example: []
        /// </param>
        /// <param name="chainOfThought">
        /// Chain of thought for the message<br/>
        /// Example: The user is asking about their order. I should first greet them and then ask for their order number.
        /// </param>
        /// <param name="rawContents"></param>
        /// <param name="error">
        /// Error message, if any<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="configuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConversation1ContentItemItem(
            int? id,
            string? sId,
            string? type,
            string? visibility,
            int? version,
            int? created,
            global::Dust.User? user,
            global::System.Collections.Generic.IList<global::Dust.Mention>? mentions,
            string? content,
            global::Dust.Context? context,
            int? agentMessageId,
            string? parentMessageId,
            string? status,
            byte[]? actions,
            string? chainOfThought,
            global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemRawContent>? rawContents,
            string? error,
            global::Dust.AgentConfiguration? configuration)
        {
            this.Id = id;
            this.SId = sId;
            this.Type = type;
            this.Visibility = visibility;
            this.Version = version;
            this.Created = created;
            this.User = user;
            this.Mentions = mentions;
            this.Content = content;
            this.Context = context;
            this.AgentMessageId = agentMessageId;
            this.ParentMessageId = parentMessageId;
            this.Status = status;
            this.Actions = actions;
            this.ChainOfThought = chainOfThought;
            this.RawContents = rawContents;
            this.Error = error;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1ContentItemItem" /> class.
        /// </summary>
        public ConversationConversation1ContentItemItem()
        {
        }
    }
}