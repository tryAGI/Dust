
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesAppsResponseApp
    {
        /// <summary>
        /// Unique identifier for the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Unique string identifier for the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Name of the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Saved specification of the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savedSpecification")]
        public string? SavedSpecification { get; set; }

        /// <summary>
        /// Saved configuration of the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savedConfig")]
        public string? SavedConfig { get; set; }

        /// <summary>
        /// Saved run identifier of the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savedRun")]
        public string? SavedRun { get; set; }

        /// <summary>
        /// ID of the associated Dust API project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dustAPIProjectId")]
        public string? DustAPIProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesAppsResponseApp" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the app
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the app
        /// </param>
        /// <param name="name">
        /// Name of the app
        /// </param>
        /// <param name="description">
        /// Description of the app
        /// </param>
        /// <param name="savedSpecification">
        /// Saved specification of the app
        /// </param>
        /// <param name="savedConfig">
        /// Saved configuration of the app
        /// </param>
        /// <param name="savedRun">
        /// Saved run identifier of the app
        /// </param>
        /// <param name="dustAPIProjectId">
        /// ID of the associated Dust API project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesAppsResponseApp(
            int? id,
            string? sId,
            string? name,
            string? description,
            string? savedSpecification,
            string? savedConfig,
            string? savedRun,
            string? dustAPIProjectId)
        {
            this.Id = id;
            this.SId = sId;
            this.Name = name;
            this.Description = description;
            this.SavedSpecification = savedSpecification;
            this.SavedConfig = savedConfig;
            this.SavedRun = savedRun;
            this.DustAPIProjectId = dustAPIProjectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesAppsResponseApp" /> class.
        /// </summary>
        public GetWSpacesAppsResponseApp()
        {
        }
    }
}