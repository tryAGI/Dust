#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWAssistantAgentConfigurationsWithAuthorsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.GetWAssistantAgentConfigurationsWithAuthors?>
    {
        /// <inheritdoc />
        public override global::Dust.GetWAssistantAgentConfigurationsWithAuthors? Read(
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
                        return global::Dust.GetWAssistantAgentConfigurationsWithAuthorsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.GetWAssistantAgentConfigurationsWithAuthors)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.GetWAssistantAgentConfigurationsWithAuthors?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.GetWAssistantAgentConfigurationsWithAuthors? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.GetWAssistantAgentConfigurationsWithAuthorsExtensions.ToValueString(value.Value));
            }
        }
    }
}
