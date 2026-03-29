
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateLightAgentConfigurationModelReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Light,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateLightAgentConfigurationModelReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLightAgentConfigurationModelReasoningEffort value)
        {
            return value switch
            {
                PrivateLightAgentConfigurationModelReasoningEffort.High => "high",
                PrivateLightAgentConfigurationModelReasoningEffort.Light => "light",
                PrivateLightAgentConfigurationModelReasoningEffort.Medium => "medium",
                PrivateLightAgentConfigurationModelReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLightAgentConfigurationModelReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PrivateLightAgentConfigurationModelReasoningEffort.High,
                "light" => PrivateLightAgentConfigurationModelReasoningEffort.Light,
                "medium" => PrivateLightAgentConfigurationModelReasoningEffort.Medium,
                "none" => PrivateLightAgentConfigurationModelReasoningEffort.None,
                _ => null,
            };
        }
    }
}