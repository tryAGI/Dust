
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentActionSuccessEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentActionSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentActionSuccessEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentActionSuccessEventType value)
        {
            return value switch
            {
                PrivateAgentActionSuccessEventType.AgentActionSuccess => "agent_action_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentActionSuccessEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_action_success" => PrivateAgentActionSuccessEventType.AgentActionSuccess,
                _ => null,
            };
        }
    }
}