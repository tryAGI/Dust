
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWSpacesKindItem
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
    public static class GetWSpacesKindItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSpacesKindItem value)
        {
            return value switch
            {
                GetWSpacesKindItem.Conversations => "conversations",
                GetWSpacesKindItem.Global => "global",
                GetWSpacesKindItem.Project => "project",
                GetWSpacesKindItem.Regular => "regular",
                GetWSpacesKindItem.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSpacesKindItem? ToEnum(string value)
        {
            return value switch
            {
                "conversations" => GetWSpacesKindItem.Conversations,
                "global" => GetWSpacesKindItem.Global,
                "project" => GetWSpacesKindItem.Project,
                "regular" => GetWSpacesKindItem.Regular,
                "system" => GetWSpacesKindItem.System,
                _ => null,
            };
        }
    }
}