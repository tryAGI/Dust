
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItemType value)
        {
            return value switch
            {
                CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItemType.Mcp => "MCP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItemType? ToEnum(string value)
        {
            return value switch
            {
                "MCP" => CreateWAssistantAgentConfigurationsImportYamlRequestToolsetItemType.Mcp,
                _ => null,
            };
        }
    }
}