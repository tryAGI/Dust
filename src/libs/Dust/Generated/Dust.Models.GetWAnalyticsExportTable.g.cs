
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAnalyticsExportTable
    {
        /// <summary>
        /// Daily, weekly, and monthly active user counts.
        /// </summary>
        ActiveUsers,
        /// <summary>
        /// Top agents by message count.
        /// </summary>
        Agents,
        /// <summary>
        /// Detailed message-level logs.
        /// </summary>
        Messages,
        /// <summary>
        /// Skill executions and unique users over time.
        /// </summary>
        SkillUsage,
        /// <summary>
        /// Message volume by context origin (web, slack, etc.).
        /// </summary>
        Source,
        /// <summary>
        /// Tool executions and unique users over time.
        /// </summary>
        ToolUsage,
        /// <summary>
        /// Messages, conversations, and active users over time.
        /// </summary>
        UsageMetrics,
        /// <summary>
        /// Messages, conversations, and active users over time.
        /// </summary>
        Users,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAnalyticsExportTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAnalyticsExportTable value)
        {
            return value switch
            {
                GetWAnalyticsExportTable.ActiveUsers => "active_users",
                GetWAnalyticsExportTable.Agents => "agents",
                GetWAnalyticsExportTable.Messages => "messages",
                GetWAnalyticsExportTable.SkillUsage => "skill_usage",
                GetWAnalyticsExportTable.Source => "source",
                GetWAnalyticsExportTable.ToolUsage => "tool_usage",
                GetWAnalyticsExportTable.UsageMetrics => "usage_metrics",
                GetWAnalyticsExportTable.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAnalyticsExportTable? ToEnum(string value)
        {
            return value switch
            {
                "active_users" => GetWAnalyticsExportTable.ActiveUsers,
                "agents" => GetWAnalyticsExportTable.Agents,
                "messages" => GetWAnalyticsExportTable.Messages,
                "skill_usage" => GetWAnalyticsExportTable.SkillUsage,
                "source" => GetWAnalyticsExportTable.Source,
                "tool_usage" => GetWAnalyticsExportTable.ToolUsage,
                "usage_metrics" => GetWAnalyticsExportTable.UsageMetrics,
                "users" => GetWAnalyticsExportTable.Users,
                _ => null,
            };
        }
    }
}