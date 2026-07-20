
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsSelectableSpacesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaces")]
        public global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>>? Spaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsSelectableSpacesResponse" /> class.
        /// </summary>
        /// <param name="spaces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsSelectableSpacesResponse(
            global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>>? spaces)
        {
            this.Spaces = spaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsSelectableSpacesResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsSelectableSpacesResponse()
        {
        }

    }
}