#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PrivateConversationForkPreparedEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateConversationForkPreparedEventType?>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateConversationForkPreparedEventType? Read(
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
                        return global::Dust.PrivateConversationForkPreparedEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.PrivateConversationForkPreparedEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.PrivateConversationForkPreparedEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateConversationForkPreparedEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.PrivateConversationForkPreparedEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
