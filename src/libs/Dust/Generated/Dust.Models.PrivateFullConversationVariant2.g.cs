
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateFullConversationVariant2
    {
        /// <summary>
        /// Workspace as returned by the private API, includes SSO and provider settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Dust.PrivateWorkspace? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateFullConversationVariant2VisibilityJsonConverter))]
        public global::Dust.PrivateFullConversationVariant2Visibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchId")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Array of message arrays (versions/retries)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>>>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFullConversationVariant2" /> class.
        /// </summary>
        /// <param name="owner">
        /// Workspace as returned by the private API, includes SSO and provider settings.
        /// </param>
        /// <param name="visibility"></param>
        /// <param name="branchId"></param>
        /// <param name="content">
        /// Array of message arrays (versions/retries)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFullConversationVariant2(
            global::Dust.PrivateWorkspace? owner,
            global::Dust.PrivateFullConversationVariant2Visibility? visibility,
            string? branchId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>>>? content)
        {
            this.Owner = owner;
            this.Visibility = visibility;
            this.BranchId = branchId;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFullConversationVariant2" /> class.
        /// </summary>
        public PrivateFullConversationVariant2()
        {
        }
    }
}