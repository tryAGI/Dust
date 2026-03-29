#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContextAgenticMessageDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.ContextAgenticMessageDataType>
    {
        /// <inheritdoc />
        public override global::Dust.ContextAgenticMessageDataType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Dust.ContextAgenticMessageDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.ContextAgenticMessageDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.ContextAgenticMessageDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.ContextAgenticMessageDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dust.ContextAgenticMessageDataTypeExtensions.ToValueString(value));
        }
    }
}
