
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateConsumptionFacet
    {
        /// <summary>
        /// Raw indexed value accepted by the corresponding consumption filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Human-readable label, falling back to the raw value when its resource was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Design-system icon name for tool and skill facets when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Number of matching indexed documents after applying the selected period and every other facet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentCount { get; set; }

        /// <summary>
        /// Whether selecting this value would produce no matching indexed document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// Current agent scope, when the agent still has accessible configuration metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateConsumptionFacetScopeJsonConverter))]
        public global::Dust.PrivateConsumptionFacetScope? Scope { get; set; }

        /// <summary>
        /// Model maker, for known model facets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maker")]
        public string? Maker { get; set; }

        /// <summary>
        /// Default reasoning-effort tier, for known model facets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateConsumptionFacetTierJsonConverter))]
        public global::Dust.PrivateConsumptionFacetTier? Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConsumptionFacet" /> class.
        /// </summary>
        /// <param name="value">
        /// Raw indexed value accepted by the corresponding consumption filter.
        /// </param>
        /// <param name="label">
        /// Human-readable label, falling back to the raw value when its resource was deleted.
        /// </param>
        /// <param name="documentCount">
        /// Number of matching indexed documents after applying the selected period and every other facet.
        /// </param>
        /// <param name="disabled">
        /// Whether selecting this value would produce no matching indexed document.
        /// </param>
        /// <param name="pictureUrl"></param>
        /// <param name="icon">
        /// Design-system icon name for tool and skill facets when known.
        /// </param>
        /// <param name="scope">
        /// Current agent scope, when the agent still has accessible configuration metadata.
        /// </param>
        /// <param name="maker">
        /// Model maker, for known model facets.
        /// </param>
        /// <param name="tier">
        /// Default reasoning-effort tier, for known model facets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConsumptionFacet(
            string value,
            string label,
            int documentCount,
            bool disabled,
            string? pictureUrl,
            string? icon,
            global::Dust.PrivateConsumptionFacetScope? scope,
            string? maker,
            global::Dust.PrivateConsumptionFacetTier? tier)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PictureUrl = pictureUrl;
            this.Icon = icon;
            this.DocumentCount = documentCount;
            this.Disabled = disabled;
            this.Scope = scope;
            this.Maker = maker;
            this.Tier = tier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConsumptionFacet" /> class.
        /// </summary>
        public PrivateConsumptionFacet()
        {
        }

    }
}