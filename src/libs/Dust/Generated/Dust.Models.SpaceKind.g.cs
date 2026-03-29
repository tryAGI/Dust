
#nullable enable

namespace Dust
{
    /// <summary>
    /// The kind of the space
    /// </summary>
    public enum SpaceKind
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Public,
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
    public static class SpaceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpaceKind value)
        {
            return value switch
            {
                SpaceKind.Global => "global",
                SpaceKind.Public => "public",
                SpaceKind.Regular => "regular",
                SpaceKind.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpaceKind? ToEnum(string value)
        {
            return value switch
            {
                "global" => SpaceKind.Global,
                "public" => SpaceKind.Public,
                "regular" => SpaceKind.Regular,
                "system" => SpaceKind.System,
                _ => null,
            };
        }
    }
}