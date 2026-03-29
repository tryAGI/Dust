
#nullable enable

namespace Dust
{
    /// <summary>
    /// Optional, returned when withUsage query param is set
    /// </summary>
    public sealed partial class PrivateLightAgentConfigurationUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageCount")]
        public int? MessageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationCount")]
        public int? ConversationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userCount")]
        public int? UserCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timePeriodSec")]
        public int? TimePeriodSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationUsage" /> class.
        /// </summary>
        /// <param name="messageCount"></param>
        /// <param name="conversationCount"></param>
        /// <param name="userCount"></param>
        /// <param name="timePeriodSec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentConfigurationUsage(
            int? messageCount,
            int? conversationCount,
            int? userCount,
            int? timePeriodSec)
        {
            this.MessageCount = messageCount;
            this.ConversationCount = conversationCount;
            this.UserCount = userCount;
            this.TimePeriodSec = timePeriodSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationUsage" /> class.
        /// </summary>
        public PrivateLightAgentConfigurationUsage()
        {
        }
    }
}