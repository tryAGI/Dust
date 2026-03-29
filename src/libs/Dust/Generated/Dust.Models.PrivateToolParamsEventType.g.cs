
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateToolParamsEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolParams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateToolParamsEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateToolParamsEventType value)
        {
            return value switch
            {
                PrivateToolParamsEventType.ToolParams => "tool_params",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateToolParamsEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool_params" => PrivateToolParamsEventType.ToolParams,
                _ => null,
            };
        }
    }
}