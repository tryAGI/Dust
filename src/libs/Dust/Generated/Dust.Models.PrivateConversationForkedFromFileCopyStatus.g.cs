
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateConversationForkedFromFileCopyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateConversationForkedFromFileCopyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateConversationForkedFromFileCopyStatus value)
        {
            return value switch
            {
                PrivateConversationForkedFromFileCopyStatus.Done => "done",
                PrivateConversationForkedFromFileCopyStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateConversationForkedFromFileCopyStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => PrivateConversationForkedFromFileCopyStatus.Done,
                "pending" => PrivateConversationForkedFromFileCopyStatus.Pending,
                _ => null,
            };
        }
    }
}