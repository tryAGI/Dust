
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantConversationsRequestVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Read { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequestVariant22" /> class.
        /// </summary>
        /// <param name="read"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantConversationsRequestVariant22(
            bool read)
        {
            this.Read = read;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequestVariant22" /> class.
        /// </summary>
        public PatchWAssistantConversationsRequestVariant22()
        {
        }

    }
}