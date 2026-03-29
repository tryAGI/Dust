#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWAssistantAgentConfigurationsVariantJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.GetWAssistantAgentConfigurationsVariant>
    {
        /// <inheritdoc />
        public override global::Dust.GetWAssistantAgentConfigurationsVariant Read(
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
                        return global::Dust.GetWAssistantAgentConfigurationsVariantExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.GetWAssistantAgentConfigurationsVariant)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.GetWAssistantAgentConfigurationsVariant);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.GetWAssistantAgentConfigurationsVariant value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dust.GetWAssistantAgentConfigurationsVariantExtensions.ToValueString(value));
        }
    }
}
