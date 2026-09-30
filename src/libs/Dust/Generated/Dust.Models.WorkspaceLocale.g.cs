
#nullable enable

namespace Dust
{
    /// <summary>
    /// Default language of the product UI for the workspace members<br/>
    /// Example: en-US
    /// </summary>
    public enum WorkspaceLocale
    {
        /// <summary>
        ///
        /// </summary>
        EnGb,
        /// <summary>
        ///
        /// </summary>
        EnUs,
        /// <summary>
        ///
        /// </summary>
        FrFr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceLocaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceLocale value)
        {
            return value switch
            {
                WorkspaceLocale.EnGb => "en-GB",
                WorkspaceLocale.EnUs => "en-US",
                WorkspaceLocale.FrFr => "fr-FR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceLocale? ToEnum(string value)
        {
            return value switch
            {
                "en-GB" => WorkspaceLocale.EnGb,
                "en-US" => WorkspaceLocale.EnUs,
                "fr-FR" => WorkspaceLocale.FrFr,
                _ => null,
            };
        }
    }
}