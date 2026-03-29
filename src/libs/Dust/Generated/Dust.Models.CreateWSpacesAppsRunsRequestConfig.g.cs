
#nullable enable

namespace Dust
{
    /// <summary>
    /// Configuration for the app run
    /// </summary>
    public sealed partial class CreateWSpacesAppsRunsRequestConfig
    {
        /// <summary>
        /// Model configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Dust.CreateWSpacesAppsRunsRequestConfigModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsRequestConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Model configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesAppsRunsRequestConfig(
            global::Dust.CreateWSpacesAppsRunsRequestConfigModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsRequestConfig" /> class.
        /// </summary>
        public CreateWSpacesAppsRunsRequestConfig()
        {
        }
    }
}