
#nullable enable

namespace Dust
{
    /// <summary>
    /// How resolvedModel was chosen - agent (configured model), user (per-message picker), or auto (routed through the auto model). Null (legacy).
    /// </summary>
    public enum PrivateLightAgentMessageModelResolutionMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateLightAgentMessageModelResolutionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLightAgentMessageModelResolutionMethod value)
        {
            return value switch
            {
                PrivateLightAgentMessageModelResolutionMethod.Agent => "agent",
                PrivateLightAgentMessageModelResolutionMethod.Auto => "auto",
                PrivateLightAgentMessageModelResolutionMethod.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLightAgentMessageModelResolutionMethod? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PrivateLightAgentMessageModelResolutionMethod.Agent,
                "auto" => PrivateLightAgentMessageModelResolutionMethod.Auto,
                "user" => PrivateLightAgentMessageModelResolutionMethod.User,
                _ => null,
            };
        }
    }
}