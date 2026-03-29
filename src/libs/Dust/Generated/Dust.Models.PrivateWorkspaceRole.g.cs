
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateWorkspaceRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Builder,
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
    public static class PrivateWorkspaceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateWorkspaceRole value)
        {
            return value switch
            {
                PrivateWorkspaceRole.Admin => "admin",
                PrivateWorkspaceRole.Builder => "builder",
                PrivateWorkspaceRole.None => "none",
                PrivateWorkspaceRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateWorkspaceRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PrivateWorkspaceRole.Admin,
                "builder" => PrivateWorkspaceRole.Builder,
                "none" => PrivateWorkspaceRole.None,
                "user" => PrivateWorkspaceRole.User,
                _ => null,
            };
        }
    }
}