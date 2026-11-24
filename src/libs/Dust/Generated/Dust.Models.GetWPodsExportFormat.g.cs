
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum GetWPodsExportFormat
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
    public static class GetWPodsExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWPodsExportFormat value)
        {
            return value switch
            {
                GetWPodsExportFormat.Csv => "csv",
                GetWPodsExportFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWPodsExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => GetWPodsExportFormat.Csv,
                "json" => GetWPodsExportFormat.Json,
                _ => null,
            };
        }
    }
}