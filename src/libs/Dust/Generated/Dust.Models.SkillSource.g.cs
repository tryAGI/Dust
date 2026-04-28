
#nullable enable

namespace Dust
{
    /// <summary>
    /// Source used to create or import the skill
    /// </summary>
    public enum SkillSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        LocalFile,
        /// <summary>
        /// 
        /// </summary>
        WebApp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillSource value)
        {
            return value switch
            {
                SkillSource.Api => "api",
                SkillSource.Github => "github",
                SkillSource.LocalFile => "local_file",
                SkillSource.WebApp => "web_app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => SkillSource.Api,
                "github" => SkillSource.Github,
                "local_file" => SkillSource.LocalFile,
                "web_app" => SkillSource.WebApp,
                _ => null,
            };
        }
    }
}