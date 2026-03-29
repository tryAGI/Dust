
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsParticipantsResponseParticipants
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponseParticipants" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsParticipantsResponseParticipants(
            global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent>? agents,
            global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser>? users)
        {
            this.Agents = agents;
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponseParticipants" /> class.
        /// </summary>
        public GetWAssistantConversationsParticipantsResponseParticipants()
        {
        }
    }
}