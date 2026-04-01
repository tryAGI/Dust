
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateLightAgentMessageActivityStepType
    {
        /// <summary>
        /// 
        /// </summary>
        Action,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateLightAgentMessageActivityStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLightAgentMessageActivityStepType value)
        {
            return value switch
            {
                PrivateLightAgentMessageActivityStepType.Action => "action",
                PrivateLightAgentMessageActivityStepType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLightAgentMessageActivityStepType? ToEnum(string value)
        {
            return value switch
            {
                "action" => PrivateLightAgentMessageActivityStepType.Action,
                "thinking" => PrivateLightAgentMessageActivityStepType.Thinking,
                _ => null,
            };
        }
    }
}