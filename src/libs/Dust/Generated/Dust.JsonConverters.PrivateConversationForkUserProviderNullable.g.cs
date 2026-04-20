#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PrivateConversationForkUserProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateConversationForkUserProvider?>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateConversationForkUserProvider? Read(
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
                        return global::Dust.PrivateConversationForkUserProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.PrivateConversationForkUserProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.PrivateConversationForkUserProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateConversationForkUserProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.PrivateConversationForkUserProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
