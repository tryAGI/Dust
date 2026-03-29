
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentGenerationCancelledEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentGenerationCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentGenerationCancelledEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentGenerationCancelledEventType value)
        {
            return value switch
            {
                PrivateAgentGenerationCancelledEventType.AgentGenerationCancelled => "agent_generation_cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentGenerationCancelledEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_generation_cancelled" => PrivateAgentGenerationCancelledEventType.AgentGenerationCancelled,
                _ => null,
            };
        }
    }
}