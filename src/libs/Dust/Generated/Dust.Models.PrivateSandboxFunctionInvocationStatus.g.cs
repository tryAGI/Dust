
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum PrivateSandboxFunctionInvocationStatus
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Errored,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSandboxFunctionInvocationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSandboxFunctionInvocationStatus value)
        {
            return value switch
            {
                PrivateSandboxFunctionInvocationStatus.Created => "created",
                PrivateSandboxFunctionInvocationStatus.Errored => "errored",
                PrivateSandboxFunctionInvocationStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSandboxFunctionInvocationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PrivateSandboxFunctionInvocationStatus.Created,
                "errored" => PrivateSandboxFunctionInvocationStatus.Errored,
                "succeeded" => PrivateSandboxFunctionInvocationStatus.Succeeded,
                _ => null,
            };
        }
    }
}