
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum GetWSpacesResponseSpaceGroupRole
    {
        /// <summary>
        ///
        /// </summary>
        Editor,
        /// <summary>
        ///
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWSpacesResponseSpaceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSpacesResponseSpaceGroupRole value)
        {
            return value switch
            {
                GetWSpacesResponseSpaceGroupRole.Editor => "editor",
                GetWSpacesResponseSpaceGroupRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSpacesResponseSpaceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "editor" => GetWSpacesResponseSpaceGroupRole.Editor,
                "member" => GetWSpacesResponseSpaceGroupRole.Member,
                _ => null,
            };
        }
    }
}