
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantConversationsRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequestVariant3" /> class.
        /// </summary>
        /// <param name="spaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantConversationsRequestVariant3(
            string spaceId)
        {
            this.SpaceId = spaceId ?? throw new global::System.ArgumentNullException(nameof(spaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequestVariant3" /> class.
        /// </summary>
        public PatchWAssistantConversationsRequestVariant3()
        {
        }
    }
}