
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceIds")]
        public global::System.Collections.Generic.IList<string>? SpaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewerMustHaveAll")]
        public bool? ViewerMustHaveAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl" /> class.
        /// </summary>
        /// <param name="spaceIds"></param>
        /// <param name="viewerMustHaveAll"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl(
            global::System.Collections.Generic.IList<string>? spaceIds,
            bool? viewerMustHaveAll)
        {
            this.SpaceIds = spaceIds;
            this.ViewerMustHaveAll = viewerMustHaveAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl" /> class.
        /// </summary>
        public CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl()
        {
        }

    }
}