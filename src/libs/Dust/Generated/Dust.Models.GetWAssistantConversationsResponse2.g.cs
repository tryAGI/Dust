
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateConversation>? Conversations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastValue")]
        public string? LastValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsResponse2" /> class.
        /// </summary>
        /// <param name="conversations"></param>
        /// <param name="hasMore"></param>
        /// <param name="lastValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsResponse2(
            global::System.Collections.Generic.IList<global::Dust.PrivateConversation>? conversations,
            bool? hasMore,
            string? lastValue)
        {
            this.Conversations = conversations;
            this.HasMore = hasMore;
            this.LastValue = lastValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsResponse2" /> class.
        /// </summary>
        public GetWAssistantConversationsResponse2()
        {
        }
    }
}