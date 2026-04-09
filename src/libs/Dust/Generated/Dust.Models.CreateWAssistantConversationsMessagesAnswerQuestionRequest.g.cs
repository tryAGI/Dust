
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesAnswerQuestionRequest
    {
        /// <summary>
        /// ID of the action to answer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer Answer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesAnswerQuestionRequest" /> class.
        /// </summary>
        /// <param name="actionId">
        /// ID of the action to answer
        /// </param>
        /// <param name="answer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesAnswerQuestionRequest(
            string actionId,
            global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer answer)
        {
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesAnswerQuestionRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesAnswerQuestionRequest()
        {
        }
    }
}