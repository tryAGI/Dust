
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWSpacesIncludeAllMembers
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWSpacesIncludeAllMembersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSpacesIncludeAllMembers value)
        {
            return value switch
            {
                GetWSpacesIncludeAllMembers.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSpacesIncludeAllMembers? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetWSpacesIncludeAllMembers.True,
                _ => null,
            };
        }
    }
}