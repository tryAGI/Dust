
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageSuccessEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessageSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMessageSuccessEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageSuccessEventType value)
        {
            return value switch
            {
                PrivateAgentMessageSuccessEventType.AgentMessageSuccess => "agent_message_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageSuccessEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message_success" => PrivateAgentMessageSuccessEventType.AgentMessageSuccess,
                _ => null,
            };
        }
    }
}