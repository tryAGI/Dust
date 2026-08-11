
#nullable enable

namespace Dust
{
    /// <summary>
    /// Default Value: cycle
    /// </summary>
    public enum CreateWAnalyticsConsumptionFacetsRequestPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Cycle,
        /// <summary>
        /// 
        /// </summary>
        Days,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAnalyticsConsumptionFacetsRequestPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAnalyticsConsumptionFacetsRequestPeriod value)
        {
            return value switch
            {
                CreateWAnalyticsConsumptionFacetsRequestPeriod.Cycle => "cycle",
                CreateWAnalyticsConsumptionFacetsRequestPeriod.Days => "days",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAnalyticsConsumptionFacetsRequestPeriod? ToEnum(string value)
        {
            return value switch
            {
                "cycle" => CreateWAnalyticsConsumptionFacetsRequestPeriod.Cycle,
                "days" => CreateWAnalyticsConsumptionFacetsRequestPeriod.Days,
                _ => null,
            };
        }
    }
}