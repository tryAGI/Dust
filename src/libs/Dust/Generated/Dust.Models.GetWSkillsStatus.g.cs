
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWSkillsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Suggested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWSkillsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSkillsStatus value)
        {
            return value switch
            {
                GetWSkillsStatus.Active => "active",
                GetWSkillsStatus.Archived => "archived",
                GetWSkillsStatus.Suggested => "suggested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSkillsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetWSkillsStatus.Active,
                "archived" => GetWSkillsStatus.Archived,
                "suggested" => GetWSkillsStatus.Suggested,
                _ => null,
            };
        }
    }
}