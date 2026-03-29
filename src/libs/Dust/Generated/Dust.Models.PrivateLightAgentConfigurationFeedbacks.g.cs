
#nullable enable

namespace Dust
{
    /// <summary>
    /// Optional, returned when withFeedbacks query param is set
    /// </summary>
    public sealed partial class PrivateLightAgentConfigurationFeedbacks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("up")]
        public int? Up { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("down")]
        public int? Down { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationFeedbacks" /> class.
        /// </summary>
        /// <param name="up"></param>
        /// <param name="down"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentConfigurationFeedbacks(
            int? up,
            int? down)
        {
            this.Up = up;
            this.Down = down;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationFeedbacks" /> class.
        /// </summary>
        public PrivateLightAgentConfigurationFeedbacks()
        {
        }
    }
}