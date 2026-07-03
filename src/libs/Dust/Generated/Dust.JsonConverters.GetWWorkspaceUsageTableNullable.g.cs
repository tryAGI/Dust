#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWWorkspaceUsageTableNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.GetWWorkspaceUsageTable?>
    {
        /// <inheritdoc />
        public override global::Dust.GetWWorkspaceUsageTable? Read(
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
                        return global::Dust.GetWWorkspaceUsageTableExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.GetWWorkspaceUsageTable)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.GetWWorkspaceUsageTable?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.GetWWorkspaceUsageTable? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.GetWWorkspaceUsageTableExtensions.ToValueString(value.Value));
            }
        }
    }
}
