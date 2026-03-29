
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentContextPrunedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentContextPruned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentContextPrunedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentContextPrunedEventType value)
        {
            return value switch
            {
                PrivateAgentContextPrunedEventType.AgentContextPruned => "agent_context_pruned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentContextPrunedEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent_context_pruned" => PrivateAgentContextPrunedEventType.AgentContextPruned,
                _ => null,
            };
        }
    }
}