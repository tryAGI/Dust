
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateContentFragmentContentFragmentVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Latest,
        /// <summary>
        /// 
        /// </summary>
        Superseded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateContentFragmentContentFragmentVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateContentFragmentContentFragmentVersion value)
        {
            return value switch
            {
                PrivateContentFragmentContentFragmentVersion.Latest => "latest",
                PrivateContentFragmentContentFragmentVersion.Superseded => "superseded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateContentFragmentContentFragmentVersion? ToEnum(string value)
        {
            return value switch
            {
                "latest" => PrivateContentFragmentContentFragmentVersion.Latest,
                "superseded" => PrivateContentFragmentContentFragmentVersion.Superseded,
                _ => null,
            };
        }
    }
}