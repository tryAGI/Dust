
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWSpacesRequestSpaceKind
    {
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Regular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWSpacesRequestSpaceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWSpacesRequestSpaceKind value)
        {
            return value switch
            {
                CreateWSpacesRequestSpaceKind.Project => "project",
                CreateWSpacesRequestSpaceKind.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWSpacesRequestSpaceKind? ToEnum(string value)
        {
            return value switch
            {
                "project" => CreateWSpacesRequestSpaceKind.Project,
                "regular" => CreateWSpacesRequestSpaceKind.Regular,
                _ => null,
            };
        }
    }
}