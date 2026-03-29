
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWAssistantConversationsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        public bool? Read { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequest" /> class.
        /// </summary>
        /// <param name="read"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantConversationsRequest(
            bool? read)
        {
            this.Read = read;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsRequest" /> class.
        /// </summary>
        public PatchWAssistantConversationsRequest()
        {
        }
    }
}