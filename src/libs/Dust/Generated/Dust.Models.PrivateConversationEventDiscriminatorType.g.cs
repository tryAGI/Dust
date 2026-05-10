
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateConversationEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessageDone,
        /// <summary>
        /// 
        /// </summary>
        AgentMessageNew,
        /// <summary>
        /// 
        /// </summary>
        CompactionMessageDone,
        /// <summary>
        /// 
        /// </summary>
        CompactionMessageNew,
        /// <summary>
        /// 
        /// </summary>
        ConversationTitle,
        /// <summary>
        /// 
        /// </summary>
        UserMessageNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateConversationEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateConversationEventDiscriminatorType value)
        {
            return value switch
            {
                PrivateConversationEventDiscriminatorType.AgentMessageDone => "agent_message_done",
                PrivateConversationEventDiscriminatorType.AgentMessageNew => "agent_message_new",
                PrivateConversationEventDiscriminatorType.CompactionMessageDone => "compaction_message_done",
                PrivateConversationEventDiscriminatorType.CompactionMessageNew => "compaction_message_new",
                PrivateConversationEventDiscriminatorType.ConversationTitle => "conversation_title",
                PrivateConversationEventDiscriminatorType.UserMessageNew => "user_message_new",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateConversationEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message_done" => PrivateConversationEventDiscriminatorType.AgentMessageDone,
                "agent_message_new" => PrivateConversationEventDiscriminatorType.AgentMessageNew,
                "compaction_message_done" => PrivateConversationEventDiscriminatorType.CompactionMessageDone,
                "compaction_message_new" => PrivateConversationEventDiscriminatorType.CompactionMessageNew,
                "conversation_title" => PrivateConversationEventDiscriminatorType.ConversationTitle,
                "user_message_new" => PrivateConversationEventDiscriminatorType.UserMessageNew,
                _ => null,
            };
        }
    }
}