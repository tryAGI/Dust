
#nullable enable

namespace Dust
{
    /// <summary>
    /// Present only for `kind: webhook` triggers
    /// </summary>
    public sealed partial class TriggerWebhookSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerWebhookSource" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider">
        /// Example: github
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerWebhookSource(
            string? name,
            string? provider)
        {
            this.Name = name;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerWebhookSource" /> class.
        /// </summary>
        public TriggerWebhookSource()
        {
        }

    }
}