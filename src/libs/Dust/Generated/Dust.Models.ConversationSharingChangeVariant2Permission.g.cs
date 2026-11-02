
#nullable enable

namespace Dust
{
    /// <summary>
    /// Write access, or `none` to remove it<br/>
    /// Example: write
    /// </summary>
    public enum ConversationSharingChangeVariant2Permission
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
    public static class ConversationSharingChangeVariant2PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSharingChangeVariant2Permission value)
        {
            return value switch
            {
                ConversationSharingChangeVariant2Permission.None => "none",
                ConversationSharingChangeVariant2Permission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSharingChangeVariant2Permission? ToEnum(string value)
        {
            return value switch
            {
                "none" => ConversationSharingChangeVariant2Permission.None,
                "write" => ConversationSharingChangeVariant2Permission.Write,
                _ => null,
            };
        }
    }
}