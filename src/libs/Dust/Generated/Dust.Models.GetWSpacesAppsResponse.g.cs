
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesAppsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesAppsResponseApp>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesAppsResponse" /> class.
        /// </summary>
        /// <param name="apps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesAppsResponse(
            global::System.Collections.Generic.IList<global::Dust.GetWSpacesAppsResponseApp>? apps)
        {
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesAppsResponse" /> class.
        /// </summary>
        public GetWSpacesAppsResponse()
        {
        }
    }
}