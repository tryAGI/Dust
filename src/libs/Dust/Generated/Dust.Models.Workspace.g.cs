
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Workspace
    {
        /// <summary>
        /// Example: 67890
        /// </summary>
        /// <example>67890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Unique string identifier for the workspace<br/>
        /// Example: dQFf9l5FQY
        /// </summary>
        /// <example>dQFf9l5FQY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Name of the workspace<br/>
        /// Example: My Awesome Workspace
        /// </summary>
        /// <example>My Awesome Workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// User's role in the workspace<br/>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Segmentation information for the workspace<br/>
        /// Example: enterprise
        /// </summary>
        /// <example>enterprise</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        public string? Segmentation { get; set; }

        /// <summary>
        /// Example: [advanced_analytics, beta_features]
        /// </summary>
        /// <example>[advanced_analytics, beta_features]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public global::System.Collections.Generic.IList<string>? Flags { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoEnforced")]
        public bool? SsoEnforced { get; set; }

        /// <summary>
        /// Example: [google, github]
        /// </summary>
        /// <example>[google, github]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("whiteListedProviders")]
        public global::System.Collections.Generic.IList<string>? WhiteListedProviders { get; set; }

        /// <summary>
        /// Default provider for embeddings in the workspace<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultEmbeddingProvider")]
        public string? DefaultEmbeddingProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 67890
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the workspace<br/>
        /// Example: dQFf9l5FQY
        /// </param>
        /// <param name="name">
        /// Name of the workspace<br/>
        /// Example: My Awesome Workspace
        /// </param>
        /// <param name="role">
        /// User's role in the workspace<br/>
        /// Example: admin
        /// </param>
        /// <param name="segmentation">
        /// Segmentation information for the workspace<br/>
        /// Example: enterprise
        /// </param>
        /// <param name="flags">
        /// Example: [advanced_analytics, beta_features]
        /// </param>
        /// <param name="ssoEnforced">
        /// Example: true
        /// </param>
        /// <param name="whiteListedProviders">
        /// Example: [google, github]
        /// </param>
        /// <param name="defaultEmbeddingProvider">
        /// Default provider for embeddings in the workspace<br/>
        /// Example: openai
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Workspace(
            int? id,
            string? sId,
            string? name,
            string? role,
            string? segmentation,
            global::System.Collections.Generic.IList<string>? flags,
            bool? ssoEnforced,
            global::System.Collections.Generic.IList<string>? whiteListedProviders,
            string? defaultEmbeddingProvider)
        {
            this.Id = id;
            this.SId = sId;
            this.Name = name;
            this.Role = role;
            this.Segmentation = segmentation;
            this.Flags = flags;
            this.SsoEnforced = ssoEnforced;
            this.WhiteListedProviders = whiteListedProviders;
            this.DefaultEmbeddingProvider = defaultEmbeddingProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        public Workspace()
        {
        }
    }
}