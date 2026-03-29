
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateDataSourceViewEditedByUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editedAt")]
        public int? EditedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceViewEditedByUser" /> class.
        /// </summary>
        /// <param name="editedAt"></param>
        /// <param name="fullName"></param>
        /// <param name="imageUrl"></param>
        /// <param name="email"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateDataSourceViewEditedByUser(
            int? editedAt,
            string? fullName,
            string? imageUrl,
            string? email,
            string? userId)
        {
            this.EditedAt = editedAt;
            this.FullName = fullName;
            this.ImageUrl = imageUrl;
            this.Email = email;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceViewEditedByUser" /> class.
        /// </summary>
        public PrivateDataSourceViewEditedByUser()
        {
        }
    }
}