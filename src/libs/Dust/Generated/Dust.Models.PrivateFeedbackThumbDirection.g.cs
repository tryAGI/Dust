
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateFeedbackThumbDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Down,
        /// <summary>
        /// 
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateFeedbackThumbDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateFeedbackThumbDirection value)
        {
            return value switch
            {
                PrivateFeedbackThumbDirection.Down => "down",
                PrivateFeedbackThumbDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateFeedbackThumbDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => PrivateFeedbackThumbDirection.Down,
                "up" => PrivateFeedbackThumbDirection.Up,
                _ => null,
            };
        }
    }
}