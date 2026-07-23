
#nullable enable

namespace Dust
{
    /// <summary>
    /// Who the skill is available to (users_and_agents makes it discoverable by agents)
    /// </summary>
    public enum SkillAvailability
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
    public static class SkillAvailabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillAvailability value)
        {
            return value switch
            {
                SkillAvailability.Editors => "editors",
                SkillAvailability.UsersAndAgents => "users_and_agents",
                SkillAvailability.WorkspaceUsers => "workspace_users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillAvailability? ToEnum(string value)
        {
            return value switch
            {
                "editors" => SkillAvailability.Editors,
                "users_and_agents" => SkillAvailability.UsersAndAgents,
                "workspace_users" => SkillAvailability.WorkspaceUsers,
                _ => null,
            };
        }
    }
}