
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchWAssistantAgentConfigurationsRequestToolsetItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchWAssistantAgentConfigurationsRequestToolsetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWAssistantAgentConfigurationsRequestToolsetItemType value)
        {
            return value switch
            {
                PatchWAssistantAgentConfigurationsRequestToolsetItemType.Mcp => "MCP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWAssistantAgentConfigurationsRequestToolsetItemType? ToEnum(string value)
        {
            return value switch
            {
                "MCP" => PatchWAssistantAgentConfigurationsRequestToolsetItemType.Mcp,
                _ => null,
            };
        }
    }
}