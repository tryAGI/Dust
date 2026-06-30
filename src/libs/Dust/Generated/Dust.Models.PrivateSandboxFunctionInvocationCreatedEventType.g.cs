
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSandboxFunctionInvocationCreatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxFunctionInvocationCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSandboxFunctionInvocationCreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSandboxFunctionInvocationCreatedEventType value)
        {
            return value switch
            {
                PrivateSandboxFunctionInvocationCreatedEventType.SandboxFunctionInvocationCreated => "sandbox_function_invocation_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSandboxFunctionInvocationCreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_function_invocation_created" => PrivateSandboxFunctionInvocationCreatedEventType.SandboxFunctionInvocationCreated,
                _ => null,
            };
        }
    }
}