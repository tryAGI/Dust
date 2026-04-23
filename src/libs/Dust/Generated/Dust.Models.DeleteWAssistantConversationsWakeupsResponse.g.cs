
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteWAssistantConversationsWakeupsResponse
    {
        /// <summary>
        /// A wake-up scheduled in a conversation to re-invoke the agent at a later time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wakeUp")]
        public global::Dust.PrivateWakeUp? WakeUp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWAssistantConversationsWakeupsResponse" /> class.
        /// </summary>
        /// <param name="wakeUp">
        /// A wake-up scheduled in a conversation to re-invoke the agent at a later time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWAssistantConversationsWakeupsResponse(
            global::Dust.PrivateWakeUp? wakeUp)
        {
            this.WakeUp = wakeUp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWAssistantConversationsWakeupsResponse" /> class.
        /// </summary>
        public DeleteWAssistantConversationsWakeupsResponse()
        {
        }
    }
}