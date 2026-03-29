
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantAgentConfigurationsWithAuthors2
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantAgentConfigurationsWithAuthors2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsWithAuthors2 value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsWithAuthors2.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsWithAuthors2? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetWAssistantAgentConfigurationsWithAuthors2.True,
                _ => null,
            };
        }
    }
}