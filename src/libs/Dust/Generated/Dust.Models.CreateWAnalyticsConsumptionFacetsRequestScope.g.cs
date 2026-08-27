
#nullable enable

namespace Dust
{
    /// <summary>
    /// Restricts which documents the facets are computed over. `automations` counts only trigger-originated runs.<br/>
    /// Default Value: all
    /// </summary>
    public enum CreateWAnalyticsConsumptionFacetsRequestScope
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Automations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAnalyticsConsumptionFacetsRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAnalyticsConsumptionFacetsRequestScope value)
        {
            return value switch
            {
                CreateWAnalyticsConsumptionFacetsRequestScope.All => "all",
                CreateWAnalyticsConsumptionFacetsRequestScope.Automations => "automations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAnalyticsConsumptionFacetsRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateWAnalyticsConsumptionFacetsRequestScope.All,
                "automations" => CreateWAnalyticsConsumptionFacetsRequestScope.Automations,
                _ => null,
            };
        }
    }
}