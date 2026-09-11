
#nullable enable

namespace Dust
{
    /// <summary>
    /// Output format (defaults to csv)
    /// </summary>
    public enum CreateWAnalyticsConsumptionExportRequestFormat
    {
        /// <summary>
        ///
        /// </summary>
        Csv,
        /// <summary>
        ///
        /// </summary>
        Ndjson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAnalyticsConsumptionExportRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAnalyticsConsumptionExportRequestFormat value)
        {
            return value switch
            {
                CreateWAnalyticsConsumptionExportRequestFormat.Csv => "csv",
                CreateWAnalyticsConsumptionExportRequestFormat.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAnalyticsConsumptionExportRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => CreateWAnalyticsConsumptionExportRequestFormat.Csv,
                "ndjson" => CreateWAnalyticsConsumptionExportRequestFormat.Ndjson,
                _ => null,
            };
        }
    }
}