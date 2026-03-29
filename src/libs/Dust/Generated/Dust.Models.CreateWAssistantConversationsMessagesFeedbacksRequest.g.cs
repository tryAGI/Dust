
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesFeedbacksRequest
    {
        /// <summary>
        /// Direction of the thumb feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbDirection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection ThumbDirection { get; set; }

        /// <summary>
        /// Optional feedback text content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbackContent")]
        public string? FeedbackContent { get; set; }

        /// <summary>
        /// Whether the conversation is shared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isConversationShared")]
        public bool? IsConversationShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesFeedbacksRequest" /> class.
        /// </summary>
        /// <param name="thumbDirection">
        /// Direction of the thumb feedback
        /// </param>
        /// <param name="feedbackContent">
        /// Optional feedback text content
        /// </param>
        /// <param name="isConversationShared">
        /// Whether the conversation is shared
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesFeedbacksRequest(
            global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection thumbDirection,
            string? feedbackContent,
            bool? isConversationShared)
        {
            this.ThumbDirection = thumbDirection;
            this.FeedbackContent = feedbackContent;
            this.IsConversationShared = isConversationShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesFeedbacksRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesFeedbacksRequest()
        {
        }
    }
}