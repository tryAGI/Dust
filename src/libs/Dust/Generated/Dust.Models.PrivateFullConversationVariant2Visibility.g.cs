
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateFullConversationVariant2Visibility
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Test,
        /// <summary>
        /// 
        /// </summary>
        Unlisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateFullConversationVariant2VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateFullConversationVariant2Visibility value)
        {
            return value switch
            {
                PrivateFullConversationVariant2Visibility.Deleted => "deleted",
                PrivateFullConversationVariant2Visibility.Test => "test",
                PrivateFullConversationVariant2Visibility.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateFullConversationVariant2Visibility? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => PrivateFullConversationVariant2Visibility.Deleted,
                "test" => PrivateFullConversationVariant2Visibility.Test,
                "unlisted" => PrivateFullConversationVariant2Visibility.Unlisted,
                _ => null,
            };
        }
    }
}