
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAnalyticsExportFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAnalyticsExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAnalyticsExportFormat value)
        {
            return value switch
            {
                GetWAnalyticsExportFormat.Csv => "csv",
                GetWAnalyticsExportFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAnalyticsExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => GetWAnalyticsExportFormat.Csv,
                "json" => GetWAnalyticsExportFormat.Json,
                _ => null,
            };
        }
    }
}