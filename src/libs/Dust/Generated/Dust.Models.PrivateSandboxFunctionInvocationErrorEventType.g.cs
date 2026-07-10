
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSandboxFunctionInvocationErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxFunctionInvocationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSandboxFunctionInvocationErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSandboxFunctionInvocationErrorEventType value)
        {
            return value switch
            {
                PrivateSandboxFunctionInvocationErrorEventType.SandboxFunctionInvocationError => "sandbox_function_invocation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSandboxFunctionInvocationErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_function_invocation_error" => PrivateSandboxFunctionInvocationErrorEventType.SandboxFunctionInvocationError,
                _ => null,
            };
        }
    }
}