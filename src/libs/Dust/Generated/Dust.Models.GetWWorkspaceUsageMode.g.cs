
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWWorkspaceUsageMode
    {
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWWorkspaceUsageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWWorkspaceUsageMode value)
        {
            return value switch
            {
                GetWWorkspaceUsageMode.Month => "month",
                GetWWorkspaceUsageMode.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWWorkspaceUsageMode? ToEnum(string value)
        {
            return value switch
            {
                "month" => GetWWorkspaceUsageMode.Month,
                "range" => GetWWorkspaceUsageMode.Range,
                _ => null,
            };
        }
    }
}