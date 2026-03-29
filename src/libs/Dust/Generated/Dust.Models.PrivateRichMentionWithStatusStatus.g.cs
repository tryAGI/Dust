
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateRichMentionWithStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        AgentRestrictedBySpaceUsage,
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        PendingConversationAccess,
        /// <summary>
        /// 
        /// </summary>
        PendingProjectMembership,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        UserRestrictedByConversationAccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateRichMentionWithStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRichMentionWithStatusStatus value)
        {
            return value switch
            {
                PrivateRichMentionWithStatusStatus.AgentRestrictedBySpaceUsage => "agent_restricted_by_space_usage",
                PrivateRichMentionWithStatusStatus.Approved => "approved",
                PrivateRichMentionWithStatusStatus.PendingConversationAccess => "pending_conversation_access",
                PrivateRichMentionWithStatusStatus.PendingProjectMembership => "pending_project_membership",
                PrivateRichMentionWithStatusStatus.Rejected => "rejected",
                PrivateRichMentionWithStatusStatus.UserRestrictedByConversationAccess => "user_restricted_by_conversation_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRichMentionWithStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "agent_restricted_by_space_usage" => PrivateRichMentionWithStatusStatus.AgentRestrictedBySpaceUsage,
                "approved" => PrivateRichMentionWithStatusStatus.Approved,
                "pending_conversation_access" => PrivateRichMentionWithStatusStatus.PendingConversationAccess,
                "pending_project_membership" => PrivateRichMentionWithStatusStatus.PendingProjectMembership,
                "rejected" => PrivateRichMentionWithStatusStatus.Rejected,
                "user_restricted_by_conversation_access" => PrivateRichMentionWithStatusStatus.UserRestrictedByConversationAccess,
                _ => null,
            };
        }
    }
}