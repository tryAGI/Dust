
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAnalyticsConsumptionFacetsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAnalyticsConsumptionFacetsResponsePeriod Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAnalyticsConsumptionFacetsResponseFacets Facets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsResponse" /> class.
        /// </summary>
        /// <param name="period"></param>
        /// <param name="facets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAnalyticsConsumptionFacetsResponse(
            global::Dust.CreateWAnalyticsConsumptionFacetsResponsePeriod period,
            global::Dust.CreateWAnalyticsConsumptionFacetsResponseFacets facets)
        {
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.Facets = facets ?? throw new global::System.ArgumentNullException(nameof(facets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsResponse" /> class.
        /// </summary>
        public CreateWAnalyticsConsumptionFacetsResponse()
        {
        }

    }
}