
#nullable enable

namespace Dust
{
    /// <summary>
    /// Conflict handling strategy. Defaults to error.
    /// </summary>
    public enum CreateWSkillsRequestOnConflict
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Override,
        /// <summary>
        /// 
        /// </summary>
        Skip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWSkillsRequestOnConflictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWSkillsRequestOnConflict value)
        {
            return value switch
            {
                CreateWSkillsRequestOnConflict.Error => "error",
                CreateWSkillsRequestOnConflict.Override => "override",
                CreateWSkillsRequestOnConflict.Skip => "skip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWSkillsRequestOnConflict? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateWSkillsRequestOnConflict.Error,
                "override" => CreateWSkillsRequestOnConflict.Override,
                "skip" => CreateWSkillsRequestOnConflict.Skip,
                _ => null,
            };
        }
    }
}