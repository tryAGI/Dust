
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageType value)
        {
            return value switch
            {
                PrivateAgentMessageType.AgentMessage => "agent_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message" => PrivateAgentMessageType.AgentMessage,
                _ => null,
            };
        }
    }
}