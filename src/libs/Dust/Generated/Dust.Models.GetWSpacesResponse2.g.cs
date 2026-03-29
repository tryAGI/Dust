
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.AllOfJsonConverter<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>))]
        public global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>? Space { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponse2" /> class.
        /// </summary>
        /// <param name="space"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesResponse2(
            global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>? space)
        {
            this.Space = space;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponse2" /> class.
        /// </summary>
        public GetWSpacesResponse2()
        {
        }
    }
}