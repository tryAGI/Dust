
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWAnalyticsConsumptionExportRequest
    {
        /// <summary>
        /// Start of the time range (inclusive), ISO 8601 datetime<br/>
        /// Example: 2026-01-01T00:00:00Z
        /// </summary>
        /// <example>2026-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// End of the time range (exclusive), ISO 8601 datetime. Must be after startDate, at most 30 days apart.<br/>
        /// Example: 2026-01-15T00:00:00Z
        /// </summary>
        /// <example>2026-01-15T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// Output format (defaults to csv)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAnalyticsConsumptionExportRequestFormatJsonConverter))]
        public global::Dust.CreateWAnalyticsConsumptionExportRequestFormat? Format { get; set; }

        /// <summary>
        /// Optional dimension filters. Each key maps to an array of string identifiers to include.<br/>
        /// Each value must be at most 256 characters. The total number of values across all dimensions must not exceed 500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Dust.CreateWAnalyticsConsumptionExportRequestFilter? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionExportRequest" /> class.
        /// </summary>
        /// <param name="startDate">
        /// Start of the time range (inclusive), ISO 8601 datetime<br/>
        /// Example: 2026-01-01T00:00:00Z
        /// </param>
        /// <param name="endDate">
        /// End of the time range (exclusive), ISO 8601 datetime. Must be after startDate, at most 30 days apart.<br/>
        /// Example: 2026-01-15T00:00:00Z
        /// </param>
        /// <param name="format">
        /// Output format (defaults to csv)
        /// </param>
        /// <param name="filter">
        /// Optional dimension filters. Each key maps to an array of string identifiers to include.<br/>
        /// Each value must be at most 256 characters. The total number of values across all dimensions must not exceed 500.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAnalyticsConsumptionExportRequest(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            global::Dust.CreateWAnalyticsConsumptionExportRequestFormat? format,
            global::Dust.CreateWAnalyticsConsumptionExportRequestFilter? filter)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Format = format;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionExportRequest" /> class.
        /// </summary>
        public CreateWAnalyticsConsumptionExportRequest()
        {
        }

    }
}