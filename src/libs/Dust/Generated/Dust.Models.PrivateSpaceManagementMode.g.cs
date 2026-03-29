
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSpaceManagementMode
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
    public static class PrivateSpaceManagementModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSpaceManagementMode value)
        {
            return value switch
            {
                PrivateSpaceManagementMode.Group => "group",
                PrivateSpaceManagementMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSpaceManagementMode? ToEnum(string value)
        {
            return value switch
            {
                "group" => PrivateSpaceManagementMode.Group,
                "manual" => PrivateSpaceManagementMode.Manual,
                _ => null,
            };
        }
    }
}