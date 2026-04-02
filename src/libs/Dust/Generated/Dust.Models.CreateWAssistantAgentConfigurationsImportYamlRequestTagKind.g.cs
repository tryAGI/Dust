
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantAgentConfigurationsImportYamlRequestTagKind
    {
        /// <summary>
        /// 
        /// </summary>
        Protected,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAssistantAgentConfigurationsImportYamlRequestTagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantAgentConfigurationsImportYamlRequestTagKind value)
        {
            return value switch
            {
                CreateWAssistantAgentConfigurationsImportYamlRequestTagKind.Protected => "protected",
                CreateWAssistantAgentConfigurationsImportYamlRequestTagKind.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantAgentConfigurationsImportYamlRequestTagKind? ToEnum(string value)
        {
            return value switch
            {
                "protected" => CreateWAssistantAgentConfigurationsImportYamlRequestTagKind.Protected,
                "standard" => CreateWAssistantAgentConfigurationsImportYamlRequestTagKind.Standard,
                _ => null,
            };
        }
    }
}