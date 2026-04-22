
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateConversationForkingData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forkedFrom")]
        public global::Dust.PrivateConversationForkedFrom? ForkedFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forkedChildren")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateConversationForkedChild>? ForkedChildren { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkingData" /> class.
        /// </summary>
        /// <param name="forkedFrom"></param>
        /// <param name="forkedChildren"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversationForkingData(
            global::Dust.PrivateConversationForkedFrom? forkedFrom,
            global::System.Collections.Generic.IList<global::Dust.PrivateConversationForkedChild>? forkedChildren)
        {
            this.ForkedFrom = forkedFrom;
            this.ForkedChildren = forkedChildren;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkingData" /> class.
        /// </summary>
        public PrivateConversationForkingData()
        {
        }
    }
}