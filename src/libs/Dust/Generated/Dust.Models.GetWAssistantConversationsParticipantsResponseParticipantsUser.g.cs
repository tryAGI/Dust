
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsParticipantsResponseParticipantsUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponseParticipantsUser" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="fullName"></param>
        /// <param name="pictureUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsParticipantsResponseParticipantsUser(
            string? username,
            string? fullName,
            string? pictureUrl)
        {
            this.Username = username;
            this.FullName = fullName;
            this.PictureUrl = pictureUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsParticipantsResponseParticipantsUser" /> class.
        /// </summary>
        public GetWAssistantConversationsParticipantsResponseParticipantsUser()
        {
        }
    }
}