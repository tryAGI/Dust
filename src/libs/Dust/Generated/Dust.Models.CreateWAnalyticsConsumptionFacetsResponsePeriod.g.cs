
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAnalyticsConsumptionFacetsResponsePeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsResponsePeriod" /> class.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAnalyticsConsumptionFacetsResponsePeriod(
            global::System.DateTime startDate,
            global::System.DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsResponsePeriod" /> class.
        /// </summary>
        public CreateWAnalyticsConsumptionFacetsResponsePeriod()
        {
        }

    }
}