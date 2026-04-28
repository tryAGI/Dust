
#nullable enable

namespace Dust
{
    /// <summary>
    /// Current status of the skill<br/>
    /// Example: active
    /// </summary>
    public enum SkillStatus
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
    public static class SkillStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillStatus value)
        {
            return value switch
            {
                SkillStatus.Active => "active",
                SkillStatus.Archived => "archived",
                SkillStatus.Suggested => "suggested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => SkillStatus.Active,
                "archived" => SkillStatus.Archived,
                "suggested" => SkillStatus.Suggested,
                _ => null,
            };
        }
    }
}