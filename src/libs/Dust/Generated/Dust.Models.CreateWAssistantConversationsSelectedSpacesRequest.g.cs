
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsSelectedSpacesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAssistantConversationsSelectedSpacesRequestModeJsonConverter))]
        public global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SpaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesRequest" /> class.
        /// </summary>
        /// <param name="spaceIds"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsSelectedSpacesRequest(
            global::System.Collections.Generic.IList<string> spaceIds,
            global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode mode)
        {
            this.Mode = mode;
            this.SpaceIds = spaceIds ?? throw new global::System.ArgumentNullException(nameof(spaceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsSelectedSpacesRequest()
        {
        }

    }
}