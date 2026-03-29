
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateButlerThinkingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ButlerThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateButlerThinkingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateButlerThinkingEventType value)
        {
            return value switch
            {
                PrivateButlerThinkingEventType.ButlerThinking => "butler_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateButlerThinkingEventType? ToEnum(string value)
        {
            return value switch
            {
                "butler_thinking" => PrivateButlerThinkingEventType.ButlerThinking,
                _ => null,
            };
        }
    }
}