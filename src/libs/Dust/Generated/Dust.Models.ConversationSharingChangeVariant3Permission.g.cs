
#nullable enable

namespace Dust
{
    /// <summary>
    /// Write access, or `none` to remove it<br/>
    /// Example: write
    /// </summary>
    public enum ConversationSharingChangeVariant3Permission
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
    public static class ConversationSharingChangeVariant3PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSharingChangeVariant3Permission value)
        {
            return value switch
            {
                ConversationSharingChangeVariant3Permission.None => "none",
                ConversationSharingChangeVariant3Permission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSharingChangeVariant3Permission? ToEnum(string value)
        {
            return value switch
            {
                "none" => ConversationSharingChangeVariant3Permission.None,
                "write" => ConversationSharingChangeVariant3Permission.Write,
                _ => null,
            };
        }
    }
}