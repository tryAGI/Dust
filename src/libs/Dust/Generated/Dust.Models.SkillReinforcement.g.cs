
#nullable enable

namespace Dust
{
    /// <summary>
    /// Reinforcement setting for the skill
    /// </summary>
    public enum SkillReinforcement
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillReinforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillReinforcement value)
        {
            return value switch
            {
                SkillReinforcement.Auto => "auto",
                SkillReinforcement.Off => "off",
                SkillReinforcement.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillReinforcement? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SkillReinforcement.Auto,
                "off" => SkillReinforcement.Off,
                "on" => SkillReinforcement.On,
                _ => null,
            };
        }
    }
}