
#nullable enable

namespace Dust
{
    /// <summary>
    /// A wake-up scheduled in a conversation to re-invoke the agent at a later time.
    /// </summary>
    public sealed partial class PrivateWakeUp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// Unix timestamp (milliseconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduleConfig")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateWakeUpScheduleConfigVariant1, global::Dust.PrivateWakeUpScheduleConfigVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.OneOf<global::Dust.PrivateWakeUpScheduleConfigVariant1, global::Dust.PrivateWakeUpScheduleConfigVariant2> ScheduleConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateWakeUpStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateWakeUpStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fireCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FireCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFires")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFires { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUp" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sId"></param>
        /// <param name="createdAt">
        /// Unix timestamp (milliseconds).
        /// </param>
        /// <param name="agentConfigurationId"></param>
        /// <param name="scheduleConfig"></param>
        /// <param name="reason"></param>
        /// <param name="status"></param>
        /// <param name="fireCount"></param>
        /// <param name="maxFires"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateWakeUp(
            int id,
            string sId,
            global::System.DateTimeOffset createdAt,
            string agentConfigurationId,
            global::Dust.OneOf<global::Dust.PrivateWakeUpScheduleConfigVariant1, global::Dust.PrivateWakeUpScheduleConfigVariant2> scheduleConfig,
            string reason,
            global::Dust.PrivateWakeUpStatus status,
            int fireCount,
            int maxFires)
        {
            this.Id = id;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.CreatedAt = createdAt;
            this.AgentConfigurationId = agentConfigurationId ?? throw new global::System.ArgumentNullException(nameof(agentConfigurationId));
            this.ScheduleConfig = scheduleConfig;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Status = status;
            this.FireCount = fireCount;
            this.MaxFires = maxFires;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUp" /> class.
        /// </summary>
        public PrivateWakeUp()
        {
        }
    }
}