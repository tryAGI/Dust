
#nullable enable

namespace Dust
{
    /// <summary>
    /// Optional availability to apply to imported or updated skills. editors is unpublished, workspace_users is published, and users_and_agents is discoverable. New skills default to editors and existing skills keep their current availability when omitted.
    /// </summary>
    public enum CreateWSkillsRequestAvailability
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
    public static class CreateWSkillsRequestAvailabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWSkillsRequestAvailability value)
        {
            return value switch
            {
                CreateWSkillsRequestAvailability.Editors => "editors",
                CreateWSkillsRequestAvailability.UsersAndAgents => "users_and_agents",
                CreateWSkillsRequestAvailability.WorkspaceUsers => "workspace_users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWSkillsRequestAvailability? ToEnum(string value)
        {
            return value switch
            {
                "editors" => CreateWSkillsRequestAvailability.Editors,
                "users_and_agents" => CreateWSkillsRequestAvailability.UsersAndAgents,
                "workspace_users" => CreateWSkillsRequestAvailability.WorkspaceUsers,
                _ => null,
            };
        }
    }
}