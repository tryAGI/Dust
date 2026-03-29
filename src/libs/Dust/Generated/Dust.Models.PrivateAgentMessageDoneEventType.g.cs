
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessageDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMessageDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageDoneEventType value)
        {
            return value switch
            {
                PrivateAgentMessageDoneEventType.AgentMessageDone => "agent_message_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message_done" => PrivateAgentMessageDoneEventType.AgentMessageDone,
                _ => null,
            };
        }
    }
}