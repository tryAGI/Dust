
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWTriggersResponse2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::Dust.Trigger>? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWTriggersResponse2" /> class.
        /// </summary>
        /// <param name="triggers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWTriggersResponse2(
            global::System.Collections.Generic.IList<global::Dust.Trigger>? triggers)
        {
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWTriggersResponse2" /> class.
        /// </summary>
        public GetWTriggersResponse2()
        {
        }

    }
}