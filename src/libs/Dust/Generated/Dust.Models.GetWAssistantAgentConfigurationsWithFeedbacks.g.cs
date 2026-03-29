
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantAgentConfigurationsWithFeedbacks
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantAgentConfigurationsWithFeedbacksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsWithFeedbacks value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsWithFeedbacks.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsWithFeedbacks? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetWAssistantAgentConfigurationsWithFeedbacks.True,
                _ => null,
            };
        }
    }
}