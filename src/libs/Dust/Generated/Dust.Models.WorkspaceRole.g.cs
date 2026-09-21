
#nullable enable

namespace Dust
{
    /// <summary>
    /// User's role in the workspace<br/>
    /// Example: admin
    /// </summary>
    public enum WorkspaceRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Manager,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceRole value)
        {
            return value switch
            {
                WorkspaceRole.Admin => "admin",
                WorkspaceRole.Manager => "manager",
                WorkspaceRole.None => "none",
                WorkspaceRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => WorkspaceRole.Admin,
                "manager" => WorkspaceRole.Manager,
                "none" => WorkspaceRole.None,
                "user" => WorkspaceRole.User,
                _ => null,
            };
        }
    }
}