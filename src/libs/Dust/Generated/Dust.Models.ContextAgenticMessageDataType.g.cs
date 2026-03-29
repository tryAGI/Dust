
#nullable enable

namespace Dust
{
    /// <summary>
    /// Type of the agentic message
    /// </summary>
    public enum ContextAgenticMessageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentHandover,
        /// <summary>
        /// 
        /// </summary>
        RunAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextAgenticMessageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextAgenticMessageDataType value)
        {
            return value switch
            {
                ContextAgenticMessageDataType.AgentHandover => "agent_handover",
                ContextAgenticMessageDataType.RunAgent => "run_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextAgenticMessageDataType? ToEnum(string value)
        {
            return value switch
            {
                "agent_handover" => ContextAgenticMessageDataType.AgentHandover,
                "run_agent" => ContextAgenticMessageDataType.RunAgent,
                _ => null,
            };
        }
    }
}