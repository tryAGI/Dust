#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PrivateToolCallStartedEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateToolCallStartedEventType?>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateToolCallStartedEventType? Read(
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
                        return global::Dust.PrivateToolCallStartedEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.PrivateToolCallStartedEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.PrivateToolCallStartedEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateToolCallStartedEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.PrivateToolCallStartedEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
