#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection>
    {
        /// <inheritdoc />
        public override global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection Read(
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
                        return global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionExtensions.ToValueString(value));
        }
    }
}
