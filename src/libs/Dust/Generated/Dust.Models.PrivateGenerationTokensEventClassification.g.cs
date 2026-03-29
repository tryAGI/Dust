
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateGenerationTokensEventClassification
    {
        /// <summary>
        /// 
        /// </summary>
        ChainOfThought,
        /// <summary>
        /// 
        /// </summary>
        ClosingDelimiter,
        /// <summary>
        /// 
        /// </summary>
        OpeningDelimiter,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateGenerationTokensEventClassificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateGenerationTokensEventClassification value)
        {
            return value switch
            {
                PrivateGenerationTokensEventClassification.ChainOfThought => "chain_of_thought",
                PrivateGenerationTokensEventClassification.ClosingDelimiter => "closing_delimiter",
                PrivateGenerationTokensEventClassification.OpeningDelimiter => "opening_delimiter",
                PrivateGenerationTokensEventClassification.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateGenerationTokensEventClassification? ToEnum(string value)
        {
            return value switch
            {
                "chain_of_thought" => PrivateGenerationTokensEventClassification.ChainOfThought,
                "closing_delimiter" => PrivateGenerationTokensEventClassification.ClosingDelimiter,
                "opening_delimiter" => PrivateGenerationTokensEventClassification.OpeningDelimiter,
                "tokens" => PrivateGenerationTokensEventClassification.Tokens,
                _ => null,
            };
        }
    }
}