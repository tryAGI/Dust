
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantConversationsRequestVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PatchWAssistantConversationsRequestVariant4AccessModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode AccessMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequestVariant4" /> class.
        /// </summary>
        /// <param name="accessMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantConversationsRequestVariant4(
            global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode accessMode)
        {
            this.AccessMode = accessMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequestVariant4" /> class.
        /// </summary>
        public PatchWAssistantConversationsRequestVariant4()
        {
        }
    }
}