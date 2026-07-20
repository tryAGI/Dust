
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsSelectedSpacesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedSpaces")]
        public global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>>? SelectedSpaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveAcl")]
        public global::Dust.CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl? EffectiveAcl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesResponse" /> class.
        /// </summary>
        /// <param name="selectedSpaces"></param>
        /// <param name="effectiveAcl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsSelectedSpacesResponse(
            global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>>? selectedSpaces,
            global::Dust.CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl? effectiveAcl)
        {
            this.SelectedSpaces = selectedSpaces;
            this.EffectiveAcl = effectiveAcl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesResponse" /> class.
        /// </summary>
        public CreateWAssistantConversationsSelectedSpacesResponse()
        {
        }

    }
}