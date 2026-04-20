
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateConversationForkedChild
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("childConversationId")]
        public string? ChildConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("childConversationTitle")]
        public string? ChildConversationTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceMessageId")]
        public string? SourceMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchedAt")]
        public int? BranchedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Dust.PrivateConversationForkUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkedChild" /> class.
        /// </summary>
        /// <param name="childConversationId"></param>
        /// <param name="childConversationTitle"></param>
        /// <param name="sourceMessageId"></param>
        /// <param name="branchedAt"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversationForkedChild(
            string? childConversationId,
            string? childConversationTitle,
            string? sourceMessageId,
            int? branchedAt,
            global::Dust.PrivateConversationForkUser? user)
        {
            this.ChildConversationId = childConversationId;
            this.ChildConversationTitle = childConversationTitle;
            this.SourceMessageId = sourceMessageId;
            this.BranchedAt = branchedAt;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkedChild" /> class.
        /// </summary>
        public PrivateConversationForkedChild()
        {
        }
    }
}