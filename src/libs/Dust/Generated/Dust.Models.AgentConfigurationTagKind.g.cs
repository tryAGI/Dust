
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentConfigurationTagKind
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
    public static class AgentConfigurationTagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConfigurationTagKind value)
        {
            return value switch
            {
                AgentConfigurationTagKind.Protected => "protected",
                AgentConfigurationTagKind.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConfigurationTagKind? ToEnum(string value)
        {
            return value switch
            {
                "protected" => AgentConfigurationTagKind.Protected,
                "standard" => AgentConfigurationTagKind.Standard,
                _ => null,
            };
        }
    }
}