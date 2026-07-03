
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWWorkspaceUsageFormat
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
    public static class GetWWorkspaceUsageFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWWorkspaceUsageFormat value)
        {
            return value switch
            {
                GetWWorkspaceUsageFormat.Csv => "csv",
                GetWWorkspaceUsageFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWWorkspaceUsageFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => GetWWorkspaceUsageFormat.Csv,
                "json" => GetWWorkspaceUsageFormat.Json,
                _ => null,
            };
        }
    }
}