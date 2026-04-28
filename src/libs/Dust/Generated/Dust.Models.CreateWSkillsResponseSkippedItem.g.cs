
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSkillsResponseSkippedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsResponseSkippedItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSkillsResponseSkippedItem(
            string? name,
            string? message)
        {
            this.Name = name;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsResponseSkippedItem" /> class.
        /// </summary>
        public CreateWSkillsResponseSkippedItem()
        {
        }
    }
}