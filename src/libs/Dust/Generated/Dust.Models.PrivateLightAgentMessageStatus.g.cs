
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateLightAgentMessageStatus
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
    public static class PrivateLightAgentMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLightAgentMessageStatus value)
        {
            return value switch
            {
                PrivateLightAgentMessageStatus.Cancelled => "cancelled",
                PrivateLightAgentMessageStatus.Created => "created",
                PrivateLightAgentMessageStatus.Failed => "failed",
                PrivateLightAgentMessageStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLightAgentMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => PrivateLightAgentMessageStatus.Cancelled,
                "created" => PrivateLightAgentMessageStatus.Created,
                "failed" => PrivateLightAgentMessageStatus.Failed,
                "succeeded" => PrivateLightAgentMessageStatus.Succeeded,
                _ => null,
            };
        }
    }
}