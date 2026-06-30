
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSandboxFunctionInvocationCreatedEventInvocationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSandboxFunctionInvocationCreatedEventInvocationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSandboxFunctionInvocationCreatedEventInvocationStatus value)
        {
            return value switch
            {
                PrivateSandboxFunctionInvocationCreatedEventInvocationStatus.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSandboxFunctionInvocationCreatedEventInvocationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PrivateSandboxFunctionInvocationCreatedEventInvocationStatus.Created,
                _ => null,
            };
        }
    }
}