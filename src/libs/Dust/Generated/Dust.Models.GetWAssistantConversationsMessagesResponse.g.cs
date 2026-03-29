
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>))]
        public global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesResponse(
            global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsMessagesResponse()
        {
        }
    }
}