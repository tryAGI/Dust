
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWWorkspaceUsageTable
    {
        /// <summary>
        /// A concatenation of all the above tables.
        /// </summary>
        All,
        /// <summary>
        /// The list of messages sent by users including the mentioned agents.
        /// </summary>
        AssistantMessages,
        /// <summary>
        /// The list of workspace agents and their corresponding usage.
        /// </summary>
        Assistants,
        /// <summary>
        /// The list of builders categorized by their activity level.
        /// </summary>
        Builders,
        /// <summary>
        /// The list of feedback given by users on the agent messages.
        /// </summary>
        Feedback,
        /// <summary>
        /// The list of users categorized by their activity level.
        /// </summary>
        Users,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWWorkspaceUsageTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWWorkspaceUsageTable value)
        {
            return value switch
            {
                GetWWorkspaceUsageTable.All => "all",
                GetWWorkspaceUsageTable.AssistantMessages => "assistant_messages",
                GetWWorkspaceUsageTable.Assistants => "assistants",
                GetWWorkspaceUsageTable.Builders => "builders",
                GetWWorkspaceUsageTable.Feedback => "feedback",
                GetWWorkspaceUsageTable.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWWorkspaceUsageTable? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetWWorkspaceUsageTable.All,
                "assistant_messages" => GetWWorkspaceUsageTable.AssistantMessages,
                "assistants" => GetWWorkspaceUsageTable.Assistants,
                "builders" => GetWWorkspaceUsageTable.Builders,
                "feedback" => GetWWorkspaceUsageTable.Feedback,
                "users" => GetWWorkspaceUsageTable.Users,
                _ => null,
            };
        }
    }
}