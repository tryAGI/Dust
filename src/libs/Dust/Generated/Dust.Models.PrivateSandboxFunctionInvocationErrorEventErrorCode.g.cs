
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSandboxFunctionInvocationErrorEventErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        BadInput,
        /// <summary>
        /// 
        /// </summary>
        BadReturn,
        /// <summary>
        /// 
        /// </summary>
        FunctionNotFound,
        /// <summary>
        /// 
        /// </summary>
        HttpError,
        /// <summary>
        /// 
        /// </summary>
        ImportFailed,
        /// <summary>
        /// 
        /// </summary>
        InvalidInput,
        /// <summary>
        /// 
        /// </summary>
        InvalidOutput,
        /// <summary>
        /// 
        /// </summary>
        InvocationFailed,
        /// <summary>
        /// 
        /// </summary>
        NotSupported,
        /// <summary>
        /// 
        /// </summary>
        Threw,
        /// <summary>
        /// 
        /// </summary>
        TransportError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSandboxFunctionInvocationErrorEventErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSandboxFunctionInvocationErrorEventErrorCode value)
        {
            return value switch
            {
                PrivateSandboxFunctionInvocationErrorEventErrorCode.BadInput => "bad_input",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.BadReturn => "bad_return",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.FunctionNotFound => "function_not_found",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.HttpError => "http_error",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.ImportFailed => "import_failed",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.InvalidInput => "invalid_input",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.InvalidOutput => "invalid_output",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.InvocationFailed => "invocation_failed",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.NotSupported => "not_supported",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.Threw => "threw",
                PrivateSandboxFunctionInvocationErrorEventErrorCode.TransportError => "transport_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSandboxFunctionInvocationErrorEventErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "bad_input" => PrivateSandboxFunctionInvocationErrorEventErrorCode.BadInput,
                "bad_return" => PrivateSandboxFunctionInvocationErrorEventErrorCode.BadReturn,
                "function_not_found" => PrivateSandboxFunctionInvocationErrorEventErrorCode.FunctionNotFound,
                "http_error" => PrivateSandboxFunctionInvocationErrorEventErrorCode.HttpError,
                "import_failed" => PrivateSandboxFunctionInvocationErrorEventErrorCode.ImportFailed,
                "invalid_input" => PrivateSandboxFunctionInvocationErrorEventErrorCode.InvalidInput,
                "invalid_output" => PrivateSandboxFunctionInvocationErrorEventErrorCode.InvalidOutput,
                "invocation_failed" => PrivateSandboxFunctionInvocationErrorEventErrorCode.InvocationFailed,
                "not_supported" => PrivateSandboxFunctionInvocationErrorEventErrorCode.NotSupported,
                "threw" => PrivateSandboxFunctionInvocationErrorEventErrorCode.Threw,
                "transport_error" => PrivateSandboxFunctionInvocationErrorEventErrorCode.TransportError,
                _ => null,
            };
        }
    }
}