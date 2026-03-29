
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateAgentMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageStatus value)
        {
            return value switch
            {
                PrivateAgentMessageStatus.Cancelled => "cancelled",
                PrivateAgentMessageStatus.Created => "created",
                PrivateAgentMessageStatus.Failed => "failed",
                PrivateAgentMessageStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => PrivateAgentMessageStatus.Cancelled,
                "created" => PrivateAgentMessageStatus.Created,
                "failed" => PrivateAgentMessageStatus.Failed,
                "succeeded" => PrivateAgentMessageStatus.Succeeded,
                _ => null,
            };
        }
    }
}