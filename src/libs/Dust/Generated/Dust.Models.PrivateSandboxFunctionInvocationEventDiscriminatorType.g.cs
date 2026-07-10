
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSandboxFunctionInvocationEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxFunctionInvocationCreated,
        /// <summary>
        /// 
        /// </summary>
        SandboxFunctionInvocationError,
        /// <summary>
        /// 
        /// </summary>
        SandboxFunctionInvocationResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSandboxFunctionInvocationEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSandboxFunctionInvocationEventDiscriminatorType value)
        {
            return value switch
            {
                PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationCreated => "sandbox_function_invocation_created",
                PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationError => "sandbox_function_invocation_error",
                PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationResult => "sandbox_function_invocation_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSandboxFunctionInvocationEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_function_invocation_created" => PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationCreated,
                "sandbox_function_invocation_error" => PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationError,
                "sandbox_function_invocation_result" => PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationResult,
                _ => null,
            };
        }
    }
}