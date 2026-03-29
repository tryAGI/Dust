
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesAppsRunsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        public global::Dust.Run? Run { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsResponse" /> class.
        /// </summary>
        /// <param name="run"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesAppsRunsResponse(
            global::Dust.Run? run)
        {
            this.Run = run;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsResponse" /> class.
        /// </summary>
        public CreateWSpacesAppsRunsResponse()
        {
        }
    }
}