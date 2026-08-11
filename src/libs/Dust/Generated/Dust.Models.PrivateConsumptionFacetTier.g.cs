
#nullable enable

namespace Dust
{
    /// <summary>
    /// Default reasoning-effort tier, for known model facets.
    /// </summary>
    public enum PrivateConsumptionFacetTier
    {
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        CostEfficient,
        /// <summary>
        /// 
        /// </summary>
        Premium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateConsumptionFacetTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateConsumptionFacetTier value)
        {
            return value switch
            {
                PrivateConsumptionFacetTier.Balanced => "balanced",
                PrivateConsumptionFacetTier.CostEfficient => "cost_efficient",
                PrivateConsumptionFacetTier.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateConsumptionFacetTier? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => PrivateConsumptionFacetTier.Balanced,
                "cost_efficient" => PrivateConsumptionFacetTier.CostEfficient,
                "premium" => PrivateConsumptionFacetTier.Premium,
                _ => null,
            };
        }
    }
}