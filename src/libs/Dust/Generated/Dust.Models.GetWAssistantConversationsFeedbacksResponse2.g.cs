
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsFeedbacksResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbacks")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateFeedback>? Feedbacks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsFeedbacksResponse2" /> class.
        /// </summary>
        /// <param name="feedbacks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsFeedbacksResponse2(
            global::System.Collections.Generic.IList<global::Dust.PrivateFeedback>? feedbacks)
        {
            this.Feedbacks = feedbacks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsFeedbacksResponse2" /> class.
        /// </summary>
        public GetWAssistantConversationsFeedbacksResponse2()
        {
        }
    }
}