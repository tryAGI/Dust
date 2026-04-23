
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsWakeupsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wakeUps")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateWakeUp>? WakeUps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsWakeupsResponse" /> class.
        /// </summary>
        /// <param name="wakeUps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsWakeupsResponse(
            global::System.Collections.Generic.IList<global::Dust.PrivateWakeUp>? wakeUps)
        {
            this.WakeUps = wakeUps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsWakeupsResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsWakeupsResponse()
        {
        }
    }
}