
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableSchemaItem
    {
        /// <summary>
        /// Name of the column<br/>
        /// Example: roi
        /// </summary>
        /// <example>roi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Data type of the column<br/>
        /// Example: int
        /// </summary>
        /// <example>int</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.TableSchemaItemValueTypeJsonConverter))]
        public global::Dust.TableSchemaItemValueType? ValueType { get; set; }

        /// <summary>
        /// Array of possible values for the column (null if unrestricted)<br/>
        /// Example: [1, 2, 3]
        /// </summary>
        /// <example>[1, 2, 3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("possible_values")]
        public global::System.Collections.Generic.IList<string>? PossibleValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSchemaItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the column<br/>
        /// Example: roi
        /// </param>
        /// <param name="valueType">
        /// Data type of the column<br/>
        /// Example: int
        /// </param>
        /// <param name="possibleValues">
        /// Array of possible values for the column (null if unrestricted)<br/>
        /// Example: [1, 2, 3]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableSchemaItem(
            string? name,
            global::Dust.TableSchemaItemValueType? valueType,
            global::System.Collections.Generic.IList<string>? possibleValues)
        {
            this.Name = name;
            this.ValueType = valueType;
            this.PossibleValues = possibleValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableSchemaItem" /> class.
        /// </summary>
        public TableSchemaItem()
        {
        }
    }
}