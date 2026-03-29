
#nullable enable

namespace Dust
{
    /// <summary>
    /// The user who last edited the data source view
    /// </summary>
    public sealed partial class DatasourceViewEditedByUser
    {
        /// <summary>
        /// Full name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// Timestamp of when the data source view was last edited by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editedAt")]
        public double? EditedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasourceViewEditedByUser" /> class.
        /// </summary>
        /// <param name="fullName">
        /// Full name of the user
        /// </param>
        /// <param name="editedAt">
        /// Timestamp of when the data source view was last edited by the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasourceViewEditedByUser(
            string? fullName,
            double? editedAt)
        {
            this.FullName = fullName;
            this.EditedAt = editedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasourceViewEditedByUser" /> class.
        /// </summary>
        public DatasourceViewEditedByUser()
        {
        }
    }
}