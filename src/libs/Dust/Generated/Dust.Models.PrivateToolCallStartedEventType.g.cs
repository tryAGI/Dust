
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateToolCallStartedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCallStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateToolCallStartedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateToolCallStartedEventType value)
        {
            return value switch
            {
                PrivateToolCallStartedEventType.ToolCallStarted => "tool_call_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateToolCallStartedEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_started" => PrivateToolCallStartedEventType.ToolCallStarted,
                _ => null,
            };
        }
    }
}