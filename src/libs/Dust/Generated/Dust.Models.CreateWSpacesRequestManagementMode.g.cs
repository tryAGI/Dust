
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWSpacesRequestManagementMode
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWSpacesRequestManagementModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWSpacesRequestManagementMode value)
        {
            return value switch
            {
                CreateWSpacesRequestManagementMode.Group => "group",
                CreateWSpacesRequestManagementMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWSpacesRequestManagementMode? ToEnum(string value)
        {
            return value switch
            {
                "group" => CreateWSpacesRequestManagementMode.Group,
                "manual" => CreateWSpacesRequestManagementMode.Manual,
                _ => null,
            };
        }
    }
}