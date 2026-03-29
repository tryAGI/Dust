
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantAgentConfigurationsWithEditors
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantAgentConfigurationsWithEditorsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsWithEditors value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsWithEditors.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsWithEditors? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetWAssistantAgentConfigurationsWithEditors.True,
                _ => null,
            };
        }
    }
}