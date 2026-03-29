
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateGenerationTokensEventType
    {
        /// <summary>
        /// 
        /// </summary>
        GenerationTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateGenerationTokensEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateGenerationTokensEventType value)
        {
            return value switch
            {
                PrivateGenerationTokensEventType.GenerationTokens => "generation_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateGenerationTokensEventType? ToEnum(string value)
        {
            return value switch
            {
                "generation_tokens" => PrivateGenerationTokensEventType.GenerationTokens,
                _ => null,
            };
        }
    }
}