
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected")]
        public bool? Selected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace" /> class.
        /// </summary>
        /// <param name="selected"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace(
            bool? selected)
        {
            this.Selected = selected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace" /> class.
        /// </summary>
        public CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace()
        {
        }

    }
}