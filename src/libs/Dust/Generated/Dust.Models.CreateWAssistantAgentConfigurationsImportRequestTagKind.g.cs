
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantAgentConfigurationsImportRequestTagKind
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
    public static class CreateWAssistantAgentConfigurationsImportRequestTagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantAgentConfigurationsImportRequestTagKind value)
        {
            return value switch
            {
                CreateWAssistantAgentConfigurationsImportRequestTagKind.Protected => "protected",
                CreateWAssistantAgentConfigurationsImportRequestTagKind.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantAgentConfigurationsImportRequestTagKind? ToEnum(string value)
        {
            return value switch
            {
                "protected" => CreateWAssistantAgentConfigurationsImportRequestTagKind.Protected,
                "standard" => CreateWAssistantAgentConfigurationsImportRequestTagKind.Standard,
                _ => null,
            };
        }
    }
}