
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateConversationForkedFrom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentConversationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentConversationTitle")]
        public string? ParentConversationTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BranchedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateConversationForkUser User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkedFrom" /> class.
        /// </summary>
        /// <param name="parentConversationId"></param>
        /// <param name="sourceMessageId"></param>
        /// <param name="branchedAt"></param>
        /// <param name="user"></param>
        /// <param name="parentConversationTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversationForkedFrom(
            string parentConversationId,
            string sourceMessageId,
            int branchedAt,
            global::Dust.PrivateConversationForkUser user,
            string? parentConversationTitle)
        {
            this.ParentConversationId = parentConversationId ?? throw new global::System.ArgumentNullException(nameof(parentConversationId));
            this.ParentConversationTitle = parentConversationTitle;
            this.SourceMessageId = sourceMessageId ?? throw new global::System.ArgumentNullException(nameof(sourceMessageId));
            this.BranchedAt = branchedAt;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkedFrom" /> class.
        /// </summary>
        public PrivateConversationForkedFrom()
        {
        }
    }
}