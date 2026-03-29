
#nullable enable

namespace Dust
{
    /// <summary>
    /// Workspace feature flags response.
    /// </summary>
    public sealed partial class PrivateFeatureFlags
    {
        /// <summary>
        /// List of enabled feature flag names for the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FeatureFlags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFeatureFlags" /> class.
        /// </summary>
        /// <param name="featureFlags">
        /// List of enabled feature flag names for the workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFeatureFlags(
            global::System.Collections.Generic.IList<string> featureFlags)
        {
            this.FeatureFlags = featureFlags ?? throw new global::System.ArgumentNullException(nameof(featureFlags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFeatureFlags" /> class.
        /// </summary>
        public PrivateFeatureFlags()
        {
        }
    }
}