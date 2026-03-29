
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesFeedbacksRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbDirection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2 ThumbDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbackContent")]
        public string? FeedbackContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isConversationShared")]
        public bool? IsConversationShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesFeedbacksRequest2" /> class.
        /// </summary>
        /// <param name="thumbDirection"></param>
        /// <param name="feedbackContent"></param>
        /// <param name="isConversationShared"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesFeedbacksRequest2(
            global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2 thumbDirection,
            string? feedbackContent,
            bool? isConversationShared)
        {
            this.ThumbDirection = thumbDirection;
            this.FeedbackContent = feedbackContent;
            this.IsConversationShared = isConversationShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesFeedbacksRequest2" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesFeedbacksRequest2()
        {
        }
    }
}