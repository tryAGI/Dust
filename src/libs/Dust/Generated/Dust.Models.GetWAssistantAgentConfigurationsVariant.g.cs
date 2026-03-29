
#nullable enable

namespace Dust
{
    /// <summary>
    /// Default Value: light
    /// </summary>
    public enum GetWAssistantAgentConfigurationsVariant
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Light,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantAgentConfigurationsVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsVariant value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsVariant.Full => "full",
                GetWAssistantAgentConfigurationsVariant.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsVariant? ToEnum(string value)
        {
            return value switch
            {
                "full" => GetWAssistantAgentConfigurationsVariant.Full,
                "light" => GetWAssistantAgentConfigurationsVariant.Light,
                _ => null,
            };
        }
    }
}