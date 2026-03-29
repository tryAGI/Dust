
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantAgentConfigurationsWithUsage
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantAgentConfigurationsWithUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsWithUsage value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsWithUsage.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsWithUsage? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetWAssistantAgentConfigurationsWithUsage.True,
                _ => null,
            };
        }
    }
}