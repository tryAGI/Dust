
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsParticipantsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("participants")]
        public global::Dust.GetWAssistantConversationsParticipantsResponseParticipants? Participants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponse" /> class.
        /// </summary>
        /// <param name="participants"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsParticipantsResponse(
            global::Dust.GetWAssistantConversationsParticipantsResponseParticipants? participants)
        {
            this.Participants = participants;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsParticipantsResponse()
        {
        }
    }
}