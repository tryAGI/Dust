
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageConsumptionUpdatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessageConsumptionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMessageConsumptionUpdatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageConsumptionUpdatedEventType value)
        {
            return value switch
            {
                PrivateAgentMessageConsumptionUpdatedEventType.AgentMessageConsumptionUpdated => "agent_message_consumption_updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageConsumptionUpdatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message_consumption_updated" => PrivateAgentMessageConsumptionUpdatedEventType.AgentMessageConsumptionUpdated,
                _ => null,
            };
        }
    }
}