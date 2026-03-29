
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesResponse
    {
        /// <summary>
        /// A space in the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        public global::Dust.PrivateSpace? Space { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesResponse" /> class.
        /// </summary>
        /// <param name="space">
        /// A space in the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesResponse(
            global::Dust.PrivateSpace? space)
        {
            this.Space = space;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesResponse" /> class.
        /// </summary>
        public PatchWSpacesResponse()
        {
        }
    }
}