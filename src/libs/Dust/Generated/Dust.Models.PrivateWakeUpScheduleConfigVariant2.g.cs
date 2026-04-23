
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateWakeUpScheduleConfigVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateWakeUpScheduleConfigVariant2TypeJsonConverter))]
        public global::Dust.PrivateWakeUpScheduleConfigVariant2Type Type { get; set; }

        /// <summary>
        /// 5-field cron expression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cron { get; set; }

        /// <summary>
        /// IANA timezone name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUpScheduleConfigVariant2" /> class.
        /// </summary>
        /// <param name="cron">
        /// 5-field cron expression.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone name.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateWakeUpScheduleConfigVariant2(
            string cron,
            string timezone,
            global::Dust.PrivateWakeUpScheduleConfigVariant2Type type)
        {
            this.Type = type;
            this.Cron = cron ?? throw new global::System.ArgumentNullException(nameof(cron));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUpScheduleConfigVariant2" /> class.
        /// </summary>
        public PrivateWakeUpScheduleConfigVariant2()
        {
        }
    }
}