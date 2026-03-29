
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkosAuthenticateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshToken")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public object? User { get; set; }

        /// <summary>
        /// Token expiry in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresIn")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Token expiry date in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public int? ExpirationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkosAuthenticateResponse" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="refreshToken"></param>
        /// <param name="user"></param>
        /// <param name="expiresIn">
        /// Token expiry in seconds
        /// </param>
        /// <param name="expirationDate">
        /// Token expiry date in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkosAuthenticateResponse(
            string? accessToken,
            string? refreshToken,
            object? user,
            int? expiresIn,
            int? expirationDate)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.User = user;
            this.ExpiresIn = expiresIn;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkosAuthenticateResponse" /> class.
        /// </summary>
        public CreateWorkosAuthenticateResponse()
        {
        }
    }
}