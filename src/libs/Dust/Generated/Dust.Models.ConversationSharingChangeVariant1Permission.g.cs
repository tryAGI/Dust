
#nullable enable

namespace Dust
{
    /// <summary>
    /// Write access, or `none` to remove it<br/>
    /// Example: write
    /// </summary>
    public enum ConversationSharingChangeVariant1Permission
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
    public static class ConversationSharingChangeVariant1PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSharingChangeVariant1Permission value)
        {
            return value switch
            {
                ConversationSharingChangeVariant1Permission.None => "none",
                ConversationSharingChangeVariant1Permission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSharingChangeVariant1Permission? ToEnum(string value)
        {
            return value switch
            {
                "none" => ConversationSharingChangeVariant1Permission.None,
                "write" => ConversationSharingChangeVariant1Permission.Write,
                _ => null,
            };
        }
    }
}