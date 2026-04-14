
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsCompactionsResponse
    {
        /// <summary>
        /// A compaction message summarizing earlier conversation content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compactionMessage")]
        public global::Dust.PrivateCompactionMessage? CompactionMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCompactionsResponse" /> class.
        /// </summary>
        /// <param name="compactionMessage">
        /// A compaction message summarizing earlier conversation content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsCompactionsResponse(
            global::Dust.PrivateCompactionMessage? compactionMessage)
        {
            this.CompactionMessage = compactionMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCompactionsResponse" /> class.
        /// </summary>
        public CreateWAssistantConversationsCompactionsResponse()
        {
        }
    }
}