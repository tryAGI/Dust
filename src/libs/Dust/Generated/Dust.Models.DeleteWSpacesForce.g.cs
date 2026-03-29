
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteWSpacesForce
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteWSpacesForceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteWSpacesForce value)
        {
            return value switch
            {
                DeleteWSpacesForce.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteWSpacesForce? ToEnum(string value)
        {
            return value switch
            {
                "true" => DeleteWSpacesForce.True,
                _ => null,
            };
        }
    }
}