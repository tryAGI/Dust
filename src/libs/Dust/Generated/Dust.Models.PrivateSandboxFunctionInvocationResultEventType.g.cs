
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSandboxFunctionInvocationResultEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxFunctionInvocationResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSandboxFunctionInvocationResultEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSandboxFunctionInvocationResultEventType value)
        {
            return value switch
            {
                PrivateSandboxFunctionInvocationResultEventType.SandboxFunctionInvocationResult => "sandbox_function_invocation_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSandboxFunctionInvocationResultEventType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_function_invocation_result" => PrivateSandboxFunctionInvocationResultEventType.SandboxFunctionInvocationResult,
                _ => null,
            };
        }
    }
}