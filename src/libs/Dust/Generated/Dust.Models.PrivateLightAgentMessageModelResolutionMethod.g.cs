
#nullable enable

namespace Dust
{
    /// <summary>
    /// How resolvedModel was chosen - agent (configured model), user (per-message picker), auto/auto_fast/auto_complex (routed through a model stream), or fair_use_downgrade (premium allowance spent, ran the Standard stream instead). Null (legacy).
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
        AutoComplex,
        /// <summary>
        ///
        /// </summary>
        AutoFast,
        /// <summary>
        ///
        /// </summary>
        FairUseDowngrade,
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
                PrivateLightAgentMessageModelResolutionMethod.AutoComplex => "auto_complex",
                PrivateLightAgentMessageModelResolutionMethod.AutoFast => "auto_fast",
                PrivateLightAgentMessageModelResolutionMethod.FairUseDowngrade => "fair_use_downgrade",
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
                "auto_complex" => PrivateLightAgentMessageModelResolutionMethod.AutoComplex,
                "auto_fast" => PrivateLightAgentMessageModelResolutionMethod.AutoFast,
                "fair_use_downgrade" => PrivateLightAgentMessageModelResolutionMethod.FairUseDowngrade,
                "user" => PrivateLightAgentMessageModelResolutionMethod.User,
                _ => null,
            };
        }
    }
}