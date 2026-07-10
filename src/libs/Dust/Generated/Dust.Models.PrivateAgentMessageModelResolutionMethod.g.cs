
#nullable enable

namespace Dust
{
    /// <summary>
    /// How resolvedModel was chosen - agent (configured model), user (per-message picker), or auto (routed through the auto model). Null (legacy).
    /// </summary>
    public enum PrivateAgentMessageModelResolutionMethod
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
    public static class PrivateAgentMessageModelResolutionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageModelResolutionMethod value)
        {
            return value switch
            {
                PrivateAgentMessageModelResolutionMethod.Agent => "agent",
                PrivateAgentMessageModelResolutionMethod.Auto => "auto",
                PrivateAgentMessageModelResolutionMethod.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageModelResolutionMethod? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PrivateAgentMessageModelResolutionMethod.Agent,
                "auto" => PrivateAgentMessageModelResolutionMethod.Auto,
                "user" => PrivateAgentMessageModelResolutionMethod.User,
                _ => null,
            };
        }
    }
}