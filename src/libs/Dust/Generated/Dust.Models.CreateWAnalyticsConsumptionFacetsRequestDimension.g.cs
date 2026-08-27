
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateWAnalyticsConsumptionFacetsRequestDimension
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        Group,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Skill,
        /// <summary>
        ///
        /// </summary>
        Source,
        /// <summary>
        ///
        /// </summary>
        Tool,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAnalyticsConsumptionFacetsRequestDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAnalyticsConsumptionFacetsRequestDimension value)
        {
            return value switch
            {
                CreateWAnalyticsConsumptionFacetsRequestDimension.Agent => "agent",
                CreateWAnalyticsConsumptionFacetsRequestDimension.ApiKey => "api_key",
                CreateWAnalyticsConsumptionFacetsRequestDimension.Group => "group",
                CreateWAnalyticsConsumptionFacetsRequestDimension.Model => "model",
                CreateWAnalyticsConsumptionFacetsRequestDimension.Skill => "skill",
                CreateWAnalyticsConsumptionFacetsRequestDimension.Source => "source",
                CreateWAnalyticsConsumptionFacetsRequestDimension.Tool => "tool",
                CreateWAnalyticsConsumptionFacetsRequestDimension.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAnalyticsConsumptionFacetsRequestDimension? ToEnum(string value)
        {
            return value switch
            {
                "agent" => CreateWAnalyticsConsumptionFacetsRequestDimension.Agent,
                "api_key" => CreateWAnalyticsConsumptionFacetsRequestDimension.ApiKey,
                "group" => CreateWAnalyticsConsumptionFacetsRequestDimension.Group,
                "model" => CreateWAnalyticsConsumptionFacetsRequestDimension.Model,
                "skill" => CreateWAnalyticsConsumptionFacetsRequestDimension.Skill,
                "source" => CreateWAnalyticsConsumptionFacetsRequestDimension.Source,
                "tool" => CreateWAnalyticsConsumptionFacetsRequestDimension.Tool,
                "user" => CreateWAnalyticsConsumptionFacetsRequestDimension.User,
                _ => null,
            };
        }
    }
}