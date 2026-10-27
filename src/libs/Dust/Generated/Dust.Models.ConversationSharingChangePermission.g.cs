
#nullable enable

namespace Dust
{
    /// <summary>
    /// Write access, or `none` to remove it<br/>
    /// Example: write
    /// </summary>
    public enum ConversationSharingChangePermission
    {
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationSharingChangePermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSharingChangePermission value)
        {
            return value switch
            {
                ConversationSharingChangePermission.None => "none",
                ConversationSharingChangePermission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSharingChangePermission? ToEnum(string value)
        {
            return value switch
            {
                "none" => ConversationSharingChangePermission.None,
                "write" => ConversationSharingChangePermission.Write,
                _ => null,
            };
        }
    }
}