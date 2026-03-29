
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentErrorEventType value)
        {
            return value switch
            {
                PrivateAgentErrorEventType.AgentError => "agent_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_error" => PrivateAgentErrorEventType.AgentError,
                _ => null,
            };
        }
    }
}