
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantConversationsRequestVisibility
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
    public static class CreateWAssistantConversationsRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantConversationsRequestVisibility value)
        {
            return value switch
            {
                CreateWAssistantConversationsRequestVisibility.Deleted => "deleted",
                CreateWAssistantConversationsRequestVisibility.Test => "test",
                CreateWAssistantConversationsRequestVisibility.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantConversationsRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => CreateWAssistantConversationsRequestVisibility.Deleted,
                "test" => CreateWAssistantConversationsRequestVisibility.Test,
                "unlisted" => CreateWAssistantConversationsRequestVisibility.Unlisted,
                _ => null,
            };
        }
    }
}