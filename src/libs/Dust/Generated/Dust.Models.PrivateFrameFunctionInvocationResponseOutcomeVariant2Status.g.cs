
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum PrivateFrameFunctionInvocationResponseOutcomeVariant2Status
    {
        /// <summary>
        ///
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateFrameFunctionInvocationResponseOutcomeVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateFrameFunctionInvocationResponseOutcomeVariant2Status value)
        {
            return value switch
            {
                PrivateFrameFunctionInvocationResponseOutcomeVariant2Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateFrameFunctionInvocationResponseOutcomeVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "errored" => PrivateFrameFunctionInvocationResponseOutcomeVariant2Status.Errored,
                _ => null,
            };
        }
    }
}