
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchWAssistantAgentConfigurationsRequestTagKind
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
    public static class PatchWAssistantAgentConfigurationsRequestTagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWAssistantAgentConfigurationsRequestTagKind value)
        {
            return value switch
            {
                PatchWAssistantAgentConfigurationsRequestTagKind.Protected => "protected",
                PatchWAssistantAgentConfigurationsRequestTagKind.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWAssistantAgentConfigurationsRequestTagKind? ToEnum(string value)
        {
            return value switch
            {
                "protected" => PatchWAssistantAgentConfigurationsRequestTagKind.Protected,
                "standard" => PatchWAssistantAgentConfigurationsRequestTagKind.Standard,
                _ => null,
            };
        }
    }
}