
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAnalyticsConsumptionFacetsRequest
    {
        /// <summary>
        /// Default Value: cycle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAnalyticsConsumptionFacetsRequestPeriodJsonConverter))]
        public global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod? Period { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        public int? Days { get; set; }

        /// <summary>
        /// Map of consumption dimensions to selected values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Dust.CreateWAnalyticsConsumptionFacetsRequestFilter? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsRequest" /> class.
        /// </summary>
        /// <param name="period">
        /// Default Value: cycle
        /// </param>
        /// <param name="days">
        /// Default Value: 30
        /// </param>
        /// <param name="filter">
        /// Map of consumption dimensions to selected values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAnalyticsConsumptionFacetsRequest(
            global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod? period,
            int? days,
            global::Dust.CreateWAnalyticsConsumptionFacetsRequestFilter? filter)
        {
            this.Period = period;
            this.Days = days;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsRequest" /> class.
        /// </summary>
        public CreateWAnalyticsConsumptionFacetsRequest()
        {
        }

    }
}