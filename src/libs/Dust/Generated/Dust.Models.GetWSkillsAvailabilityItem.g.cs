
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum GetWSkillsAvailabilityItem
    {
        /// <summary>
        ///
        /// </summary>
        Editors,
        /// <summary>
        ///
        /// </summary>
        UsersAndAgents,
        /// <summary>
        ///
        /// </summary>
        WorkspaceUsers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWSkillsAvailabilityItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSkillsAvailabilityItem value)
        {
            return value switch
            {
                GetWSkillsAvailabilityItem.Editors => "editors",
                GetWSkillsAvailabilityItem.UsersAndAgents => "users_and_agents",
                GetWSkillsAvailabilityItem.WorkspaceUsers => "workspace_users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSkillsAvailabilityItem? ToEnum(string value)
        {
            return value switch
            {
                "editors" => GetWSkillsAvailabilityItem.Editors,
                "users_and_agents" => GetWSkillsAvailabilityItem.UsersAndAgents,
                "workspace_users" => GetWSkillsAvailabilityItem.WorkspaceUsers,
                _ => null,
            };
        }
    }
}