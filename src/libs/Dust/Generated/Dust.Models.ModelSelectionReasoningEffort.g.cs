
#nullable enable

namespace Dust
{
    /// <summary>
    /// Optional reasoning effort. Honored only if the resolved model supports it. `light` is a deprecated alias of `low`.<br/>
    /// Example: medium
    /// </summary>
    public enum ModelSelectionReasoningEffort
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
        Low,
        /// <summary>
        ///
        /// </summary>
        Maximal,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelSelectionReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelSelectionReasoningEffort value)
        {
            return value switch
            {
                ModelSelectionReasoningEffort.High => "high",
                ModelSelectionReasoningEffort.Light => "light",
                ModelSelectionReasoningEffort.Low => "low",
                ModelSelectionReasoningEffort.Maximal => "maximal",
                ModelSelectionReasoningEffort.Medium => "medium",
                ModelSelectionReasoningEffort.Minimal => "minimal",
                ModelSelectionReasoningEffort.None => "none",
                ModelSelectionReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelSelectionReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelSelectionReasoningEffort.High,
                "light" => ModelSelectionReasoningEffort.Light,
                "low" => ModelSelectionReasoningEffort.Low,
                "maximal" => ModelSelectionReasoningEffort.Maximal,
                "medium" => ModelSelectionReasoningEffort.Medium,
                "minimal" => ModelSelectionReasoningEffort.Minimal,
                "none" => ModelSelectionReasoningEffort.None,
                "xhigh" => ModelSelectionReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}