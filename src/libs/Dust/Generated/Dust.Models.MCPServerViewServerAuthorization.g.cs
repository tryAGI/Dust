
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServerViewServerAuthorization
    {
        /// <summary>
        /// OAuth provider for authorization<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Supported use cases for the authorization<br/>
        /// Example: [platform_actions]
        /// </summary>
        /// <example>[platform_actions]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_use_cases")]
        public global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>? SupportedUseCases { get; set; }

        /// <summary>
        /// OAuth scope required<br/>
        /// Example: repo:read
        /// </summary>
        /// <example>repo:read</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewServerAuthorization" /> class.
        /// </summary>
        /// <param name="provider">
        /// OAuth provider for authorization<br/>
        /// Example: github
        /// </param>
        /// <param name="supportedUseCases">
        /// Supported use cases for the authorization<br/>
        /// Example: [platform_actions]
        /// </param>
        /// <param name="scope">
        /// OAuth scope required<br/>
        /// Example: repo:read
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerViewServerAuthorization(
            string? provider,
            global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>? supportedUseCases,
            string? scope)
        {
            this.Provider = provider;
            this.SupportedUseCases = supportedUseCases;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewServerAuthorization" /> class.
        /// </summary>
        public MCPServerViewServerAuthorization()
        {
        }
    }
}