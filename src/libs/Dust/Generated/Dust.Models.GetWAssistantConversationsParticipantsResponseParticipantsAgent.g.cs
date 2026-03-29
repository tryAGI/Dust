
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsParticipantsResponseParticipantsAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationName")]
        public string? ConfigurationName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponseParticipantsAgent" /> class.
        /// </summary>
        /// <param name="configurationId"></param>
        /// <param name="configurationName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsParticipantsResponseParticipantsAgent(
            string? configurationId,
            string? configurationName)
        {
            this.ConfigurationId = configurationId;
            this.ConfigurationName = configurationName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponseParticipantsAgent" /> class.
        /// </summary>
        public GetWAssistantConversationsParticipantsResponseParticipantsAgent()
        {
        }
    }
}