
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesRequestContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profilePictureUrl")]
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSideMCPServerIds")]
        public global::System.Collections.Generic.IList<string>? ClientSideMCPServerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesRequestContext" /> class.
        /// </summary>
        /// <param name="timezone"></param>
        /// <param name="profilePictureUrl"></param>
        /// <param name="origin"></param>
        /// <param name="clientSideMCPServerIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesRequestContext(
            string? timezone,
            string? profilePictureUrl,
            string? origin,
            global::System.Collections.Generic.IList<string>? clientSideMCPServerIds)
        {
            this.Timezone = timezone;
            this.ProfilePictureUrl = profilePictureUrl;
            this.Origin = origin;
            this.ClientSideMCPServerIds = clientSideMCPServerIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesRequestContext" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesRequestContext()
        {
        }
    }
}