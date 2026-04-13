
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateCompactionMessageStatus
    {
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
    public static class PrivateCompactionMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateCompactionMessageStatus value)
        {
            return value switch
            {
                PrivateCompactionMessageStatus.Created => "created",
                PrivateCompactionMessageStatus.Failed => "failed",
                PrivateCompactionMessageStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateCompactionMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => PrivateCompactionMessageStatus.Created,
                "failed" => PrivateCompactionMessageStatus.Failed,
                "succeeded" => PrivateCompactionMessageStatus.Succeeded,
                _ => null,
            };
        }
    }
}