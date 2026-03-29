#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWAssistantAgentConfigurationsWithEditorsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.GetWAssistantAgentConfigurationsWithEditors>
    {
        /// <inheritdoc />
        public override global::Dust.GetWAssistantAgentConfigurationsWithEditors Read(
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
                        return global::Dust.GetWAssistantAgentConfigurationsWithEditorsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.GetWAssistantAgentConfigurationsWithEditors)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.GetWAssistantAgentConfigurationsWithEditors);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.GetWAssistantAgentConfigurationsWithEditors value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dust.GetWAssistantAgentConfigurationsWithEditorsExtensions.ToValueString(value));
        }
    }
}
