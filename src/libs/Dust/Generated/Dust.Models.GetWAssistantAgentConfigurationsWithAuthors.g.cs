
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantAgentConfigurationsWithAuthors
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantAgentConfigurationsWithAuthorsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsWithAuthors value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsWithAuthors.False => "false",
                GetWAssistantAgentConfigurationsWithAuthors.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsWithAuthors? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetWAssistantAgentConfigurationsWithAuthors.False,
                "true" => GetWAssistantAgentConfigurationsWithAuthors.True,
                _ => null,
            };
        }
    }
}