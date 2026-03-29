
#nullable enable

namespace Dust
{
    /// <summary>
    /// Extension configuration for the workspace.
    /// </summary>
    public sealed partial class PrivateExtensionConfig
    {
        /// <summary>
        /// Domains where the extension should not activate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blacklistedDomains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BlacklistedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateExtensionConfig" /> class.
        /// </summary>
        /// <param name="blacklistedDomains">
        /// Domains where the extension should not activate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateExtensionConfig(
            global::System.Collections.Generic.IList<string> blacklistedDomains)
        {
            this.BlacklistedDomains = blacklistedDomains ?? throw new global::System.ArgumentNullException(nameof(blacklistedDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateExtensionConfig" /> class.
        /// </summary>
        public PrivateExtensionConfig()
        {
        }
    }
}