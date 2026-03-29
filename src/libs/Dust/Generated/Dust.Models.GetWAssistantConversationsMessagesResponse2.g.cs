
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastValue")]
        public int? LastValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesResponse2" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="hasMore"></param>
        /// <param name="lastValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesResponse2(
            global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>>? messages,
            bool? hasMore,
            int? lastValue)
        {
            this.Messages = messages;
            this.HasMore = hasMore;
            this.LastValue = lastValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesResponse2" /> class.
        /// </summary>
        public GetWAssistantConversationsMessagesResponse2()
        {
        }
    }
}