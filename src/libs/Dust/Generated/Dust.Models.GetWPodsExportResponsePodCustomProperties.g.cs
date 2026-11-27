
#nullable enable

namespace Dust
{
    /// <summary>
    /// Only when Pod custom properties are enabled. The pod's value of each custom property, keyed by property name, null when not set.
    /// </summary>
    public sealed partial class GetWPodsExportResponsePodCustomProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}