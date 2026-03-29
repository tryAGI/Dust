
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateToolErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateToolErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateToolErrorEventType value)
        {
            return value switch
            {
                PrivateToolErrorEventType.ToolError => "tool_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateToolErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool_error" => PrivateToolErrorEventType.ToolError,
                _ => null,
            };
        }
    }
}