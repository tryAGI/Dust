
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfiguration
    {
        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Unique string identifier for the agent configuration<br/>
        /// Example: 7f3a9c2b1e
        /// </summary>
        /// <example>7f3a9c2b1e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Timestamp of when the version was created<br/>
        /// Example: 2023-06-15T14:30:00Z
        /// </summary>
        /// <example>2023-06-15T14:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionCreatedAt")]
        public string? VersionCreatedAt { get; set; }

        /// <summary>
        /// ID of the user who created this version<br/>
        /// Example: 0ec9852c2f
        /// </summary>
        /// <example>0ec9852c2f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionAuthorId")]
        public string? VersionAuthorId { get; set; }

        /// <summary>
        /// Name of the agent configuration<br/>
        /// Example: Customer Support Agent
        /// </summary>
        /// <example>Customer Support Agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the agent configuration<br/>
        /// Example: An AI agent designed to handle customer support inquiries
        /// </summary>
        /// <example>An AI agent designed to handle customer support inquiries</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Instructions for the agent<br/>
        /// Example: Always greet the customer politely and try to resolve their issue efficiently.
        /// </summary>
        /// <example>Always greet the customer politely and try to resolve their issue efficiently.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// URL of the agent's picture<br/>
        /// Example: https://example.com/agent-images/support-agent.png
        /// </summary>
        /// <example>https://example.com/agent-images/support-agent.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Current status of the agent configuration<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Scope of the agent configuration<br/>
        /// Example: workspace
        /// </summary>
        /// <example>workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Status of the user favorite for this configuration<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFavorite")]
        public bool? UserFavorite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Dust.AgentConfigurationModel? Model { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public byte[]? Actions { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxStepsPerRun")]
        public int? MaxStepsPerRun { get; set; }

        /// <summary>
        /// ID of the template used for this configuration<br/>
        /// Example: b4e2f1a9c7
        /// </summary>
        /// <example>b4e2f1a9c7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 12345
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the agent configuration<br/>
        /// Example: 7f3a9c2b1e
        /// </param>
        /// <param name="version">
        /// Example: 2
        /// </param>
        /// <param name="versionCreatedAt">
        /// Timestamp of when the version was created<br/>
        /// Example: 2023-06-15T14:30:00Z
        /// </param>
        /// <param name="versionAuthorId">
        /// ID of the user who created this version<br/>
        /// Example: 0ec9852c2f
        /// </param>
        /// <param name="name">
        /// Name of the agent configuration<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="description">
        /// Description of the agent configuration<br/>
        /// Example: An AI agent designed to handle customer support inquiries
        /// </param>
        /// <param name="instructions">
        /// Instructions for the agent<br/>
        /// Example: Always greet the customer politely and try to resolve their issue efficiently.
        /// </param>
        /// <param name="pictureUrl">
        /// URL of the agent's picture<br/>
        /// Example: https://example.com/agent-images/support-agent.png
        /// </param>
        /// <param name="status">
        /// Current status of the agent configuration<br/>
        /// Example: active
        /// </param>
        /// <param name="scope">
        /// Scope of the agent configuration<br/>
        /// Example: workspace
        /// </param>
        /// <param name="userFavorite">
        /// Status of the user favorite for this configuration<br/>
        /// Example: true
        /// </param>
        /// <param name="model"></param>
        /// <param name="actions">
        /// Example: []
        /// </param>
        /// <param name="maxStepsPerRun">
        /// Example: 10
        /// </param>
        /// <param name="templateId">
        /// ID of the template used for this configuration<br/>
        /// Example: b4e2f1a9c7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfiguration(
            int? id,
            string? sId,
            int? version,
            string? versionCreatedAt,
            string? versionAuthorId,
            string? name,
            string? description,
            string? instructions,
            string? pictureUrl,
            string? status,
            string? scope,
            bool? userFavorite,
            global::Dust.AgentConfigurationModel? model,
            byte[]? actions,
            int? maxStepsPerRun,
            string? templateId)
        {
            this.Id = id;
            this.SId = sId;
            this.Version = version;
            this.VersionCreatedAt = versionCreatedAt;
            this.VersionAuthorId = versionAuthorId;
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.PictureUrl = pictureUrl;
            this.Status = status;
            this.Scope = scope;
            this.UserFavorite = userFavorite;
            this.Model = model;
            this.Actions = actions;
            this.MaxStepsPerRun = maxStepsPerRun;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfiguration" /> class.
        /// </summary>
        public AgentConfiguration()
        {
        }
    }
}