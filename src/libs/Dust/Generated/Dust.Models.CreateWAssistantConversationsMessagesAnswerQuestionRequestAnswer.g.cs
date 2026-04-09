
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer
    {
        /// <summary>
        /// Indices of selected options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedOptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> SelectedOptions { get; set; }

        /// <summary>
        /// Optional free-text response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customResponse")]
        public string? CustomResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer" /> class.
        /// </summary>
        /// <param name="selectedOptions">
        /// Indices of selected options
        /// </param>
        /// <param name="customResponse">
        /// Optional free-text response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer(
            global::System.Collections.Generic.IList<int> selectedOptions,
            string? customResponse)
        {
            this.SelectedOptions = selectedOptions ?? throw new global::System.ArgumentNullException(nameof(selectedOptions));
            this.CustomResponse = customResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer()
        {
        }
    }
}