
#nullable enable

namespace Dust
{
    /// <summary>
    /// How resolvedModel was chosen - agent (configured model), user (per-message picker), auto/auto_fast/auto_complex (routed through a model stream), or fair_use_downgrade (premium allowance spent, ran the Standard stream instead). Null (legacy).
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
                PrivateAgentMessageModelResolutionMethod.AutoComplex => "auto_complex",
                PrivateAgentMessageModelResolutionMethod.AutoFast => "auto_fast",
                PrivateAgentMessageModelResolutionMethod.FairUseDowngrade => "fair_use_downgrade",
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
                "auto_complex" => PrivateAgentMessageModelResolutionMethod.AutoComplex,
                "auto_fast" => PrivateAgentMessageModelResolutionMethod.AutoFast,
                "fair_use_downgrade" => PrivateAgentMessageModelResolutionMethod.FairUseDowngrade,
                "user" => PrivateAgentMessageModelResolutionMethod.User,
                _ => null,
            };
        }
    }
}