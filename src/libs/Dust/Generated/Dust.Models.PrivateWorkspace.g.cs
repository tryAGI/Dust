
#nullable enable

namespace Dust
{
    /// <summary>
    /// Workspace as returned by the private API, includes SSO and provider settings.
    /// </summary>
    public sealed partial class PrivateWorkspace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateWorkspaceRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateWorkspaceRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        public string? Segmentation { get; set; }

        /// <summary>
        /// Allowed model provider IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whiteListedProviders")]
        public global::System.Collections.Generic.IList<string>? WhiteListedProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultEmbeddingProvider")]
        public string? DefaultEmbeddingProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoEnforced")]
        public bool? SsoEnforced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWorkspace" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sId"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="segmentation"></param>
        /// <param name="whiteListedProviders">
        /// Allowed model provider IDs
        /// </param>
        /// <param name="defaultEmbeddingProvider"></param>
        /// <param name="ssoEnforced"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateWorkspace(
            int id,
            string sId,
            string name,
            global::Dust.PrivateWorkspaceRole role,
            string? segmentation,
            global::System.Collections.Generic.IList<string>? whiteListedProviders,
            string? defaultEmbeddingProvider,
            bool? ssoEnforced,
            object? metadata)
        {
            this.Id = id;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.Segmentation = segmentation;
            this.WhiteListedProviders = whiteListedProviders;
            this.DefaultEmbeddingProvider = defaultEmbeddingProvider;
            this.SsoEnforced = ssoEnforced;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWorkspace" /> class.
        /// </summary>
        public PrivateWorkspace()
        {
        }
    }
}