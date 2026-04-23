
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateWakeUpScheduleConfigVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateWakeUpScheduleConfigVariant1TypeJsonConverter))]
        public global::Dust.PrivateWakeUpScheduleConfigVariant1Type Type { get; set; }

        /// <summary>
        /// Unix timestamp (milliseconds) when the wake-up should fire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fireAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset FireAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUpScheduleConfigVariant1" /> class.
        /// </summary>
        /// <param name="fireAt">
        /// Unix timestamp (milliseconds) when the wake-up should fire.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateWakeUpScheduleConfigVariant1(
            global::System.DateTimeOffset fireAt,
            global::Dust.PrivateWakeUpScheduleConfigVariant1Type type)
        {
            this.Type = type;
            this.FireAt = fireAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUpScheduleConfigVariant1" /> class.
        /// </summary>
        public PrivateWakeUpScheduleConfigVariant1()
        {
        }
    }
}