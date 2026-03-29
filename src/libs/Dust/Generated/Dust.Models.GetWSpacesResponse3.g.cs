
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaces")]
        public global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>>? Spaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponse3" /> class.
        /// </summary>
        /// <param name="spaces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesResponse3(
            global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>>? spaces)
        {
            this.Spaces = spaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponse3" /> class.
        /// </summary>
        public GetWSpacesResponse3()
        {
        }
    }
}