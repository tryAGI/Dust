
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateSpaceKind
    {
        /// <summary>
        /// 
        /// </summary>
        Conversations,
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Regular,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateSpaceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateSpaceKind value)
        {
            return value switch
            {
                PrivateSpaceKind.Conversations => "conversations",
                PrivateSpaceKind.Global => "global",
                PrivateSpaceKind.Project => "project",
                PrivateSpaceKind.Regular => "regular",
                PrivateSpaceKind.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateSpaceKind? ToEnum(string value)
        {
            return value switch
            {
                "conversations" => PrivateSpaceKind.Conversations,
                "global" => PrivateSpaceKind.Global,
                "project" => PrivateSpaceKind.Project,
                "regular" => PrivateSpaceKind.Regular,
                "system" => PrivateSpaceKind.System,
                _ => null,
            };
        }
    }
}