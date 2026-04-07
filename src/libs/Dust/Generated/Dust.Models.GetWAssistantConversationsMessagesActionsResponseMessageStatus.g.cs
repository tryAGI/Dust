
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantConversationsMessagesActionsResponseMessageStatus
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
        GracefullyStopped,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantConversationsMessagesActionsResponseMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantConversationsMessagesActionsResponseMessageStatus value)
        {
            return value switch
            {
                GetWAssistantConversationsMessagesActionsResponseMessageStatus.Cancelled => "cancelled",
                GetWAssistantConversationsMessagesActionsResponseMessageStatus.Created => "created",
                GetWAssistantConversationsMessagesActionsResponseMessageStatus.Failed => "failed",
                GetWAssistantConversationsMessagesActionsResponseMessageStatus.GracefullyStopped => "gracefully_stopped",
                GetWAssistantConversationsMessagesActionsResponseMessageStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantConversationsMessagesActionsResponseMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => GetWAssistantConversationsMessagesActionsResponseMessageStatus.Cancelled,
                "created" => GetWAssistantConversationsMessagesActionsResponseMessageStatus.Created,
                "failed" => GetWAssistantConversationsMessagesActionsResponseMessageStatus.Failed,
                "gracefully_stopped" => GetWAssistantConversationsMessagesActionsResponseMessageStatus.GracefullyStopped,
                "succeeded" => GetWAssistantConversationsMessagesActionsResponseMessageStatus.Succeeded,
                _ => null,
            };
        }
    }
}