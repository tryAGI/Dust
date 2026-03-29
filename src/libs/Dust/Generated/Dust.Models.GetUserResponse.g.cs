
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserResponse
    {
        /// <summary>
        /// Authenticated user with their workspaces and subscriber hash.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Dust.PrivateUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserResponse" /> class.
        /// </summary>
        /// <param name="user">
        /// Authenticated user with their workspaces and subscriber hash.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserResponse(
            global::Dust.PrivateUser? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserResponse" /> class.
        /// </summary>
        public GetUserResponse()
        {
        }
    }
}