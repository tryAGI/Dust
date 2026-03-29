
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateLightAgentConfigurationScope
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        Visible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateLightAgentConfigurationScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLightAgentConfigurationScope value)
        {
            return value switch
            {
                PrivateLightAgentConfigurationScope.Global => "global",
                PrivateLightAgentConfigurationScope.Hidden => "hidden",
                PrivateLightAgentConfigurationScope.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLightAgentConfigurationScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => PrivateLightAgentConfigurationScope.Global,
                "hidden" => PrivateLightAgentConfigurationScope.Hidden,
                "visible" => PrivateLightAgentConfigurationScope.Visible,
                _ => null,
            };
        }
    }
}