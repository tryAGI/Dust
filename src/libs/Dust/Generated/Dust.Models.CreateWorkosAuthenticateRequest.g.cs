
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkosAuthenticateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWorkosAuthenticateRequestGrantTypeJsonConverter))]
        public global::Dust.CreateWorkosAuthenticateRequestGrantType? GrantType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkosAuthenticateRequest" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="grantType"></param>
        /// <param name="refreshToken"></param>
        /// <param name="codeVerifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkosAuthenticateRequest(
            string? code,
            global::Dust.CreateWorkosAuthenticateRequestGrantType? grantType,
            string? refreshToken,
            string? codeVerifier)
        {
            this.Code = code;
            this.GrantType = grantType;
            this.RefreshToken = refreshToken;
            this.CodeVerifier = codeVerifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkosAuthenticateRequest" /> class.
        /// </summary>
        public CreateWorkosAuthenticateRequest()
        {
        }
    }
}