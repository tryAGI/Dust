
#nullable enable

namespace Dust
{
    /// <summary>
    /// Optional reasoning effort. Honored only if the resolved model supports it.<br/>
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
        Medium,
        /// <summary>
        /// 
        /// </summary>
        None,
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
                ModelSelectionReasoningEffort.Medium => "medium",
                ModelSelectionReasoningEffort.None => "none",
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
                "medium" => ModelSelectionReasoningEffort.Medium,
                "none" => ModelSelectionReasoningEffort.None,
                _ => null,
            };
        }
    }
}