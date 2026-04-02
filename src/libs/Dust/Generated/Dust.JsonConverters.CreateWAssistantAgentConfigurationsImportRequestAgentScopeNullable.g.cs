#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateWAssistantAgentConfigurationsImportRequestAgentScopeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?>
    {
        /// <inheritdoc />
        public override global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope? Read(
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
                        return global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScopeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScopeExtensions.ToValueString(value.Value));
            }
        }
    }
}
