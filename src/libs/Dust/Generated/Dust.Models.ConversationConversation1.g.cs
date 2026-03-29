
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConversation1
    {
        /// <summary>
        /// Example: 67890
        /// </summary>
        /// <example>67890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: 1625097600
        /// </summary>
        /// <example>1625097600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Unique string identifier for the conversation<br/>
        /// Example: 3d8f6a2c1b
        /// </summary>
        /// <example>3d8f6a2c1b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Dust.Workspace? Owner { get; set; }

        /// <summary>
        /// Title of the conversation<br/>
        /// Example: Customer Inquiry #1234
        /// </summary>
        /// <example>Customer Inquiry #1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Visibility setting of the conversation<br/>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 67890
        /// </param>
        /// <param name="created">
        /// Example: 1625097600
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the conversation<br/>
        /// Example: 3d8f6a2c1b
        /// </param>
        /// <param name="owner"></param>
        /// <param name="title">
        /// Title of the conversation<br/>
        /// Example: Customer Inquiry #1234
        /// </param>
        /// <param name="visibility">
        /// Visibility setting of the conversation<br/>
        /// Example: private
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConversation1(
            int? id,
            int? created,
            string? sId,
            global::Dust.Workspace? owner,
            string? title,
            string? visibility,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>>? content)
        {
            this.Id = id;
            this.Created = created;
            this.SId = sId;
            this.Owner = owner;
            this.Title = title;
            this.Visibility = visibility;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1" /> class.
        /// </summary>
        public ConversationConversation1()
        {
        }
    }
}