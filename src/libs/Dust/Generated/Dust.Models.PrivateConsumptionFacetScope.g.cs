
#nullable enable

namespace Dust
{
    /// <summary>
    /// Current agent scope, when the agent still has accessible configuration metadata.
    /// </summary>
    public enum PrivateConsumptionFacetScope
    {
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        Hidden,
        /// <summary>
        ///
        /// </summary>
        Visible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateConsumptionFacetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateConsumptionFacetScope value)
        {
            return value switch
            {
                PrivateConsumptionFacetScope.Global => "global",
                PrivateConsumptionFacetScope.Hidden => "hidden",
                PrivateConsumptionFacetScope.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateConsumptionFacetScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => PrivateConsumptionFacetScope.Global,
                "hidden" => PrivateConsumptionFacetScope.Hidden,
                "visible" => PrivateConsumptionFacetScope.Visible,
                _ => null,
            };
        }
    }
}