
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantAgentConfigurationsImportRequestToolsetItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantAgentConfigurationsImportRequestToolsetItemType value)
        {
            return value switch
            {
                CreateWAssistantAgentConfigurationsImportRequestToolsetItemType.Mcp => "MCP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantAgentConfigurationsImportRequestToolsetItemType? ToEnum(string value)
        {
            return value switch
            {
                "MCP" => CreateWAssistantAgentConfigurationsImportRequestToolsetItemType.Mcp,
                _ => null,
            };
        }
    }
}