
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum PrivateFrameFunctionInvocationResponseOutcomeVariant1Status
    {
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateFrameFunctionInvocationResponseOutcomeVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateFrameFunctionInvocationResponseOutcomeVariant1Status value)
        {
            return value switch
            {
                PrivateFrameFunctionInvocationResponseOutcomeVariant1Status.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateFrameFunctionInvocationResponseOutcomeVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "succeeded" => PrivateFrameFunctionInvocationResponseOutcomeVariant1Status.Succeeded,
                _ => null,
            };
        }
    }
}