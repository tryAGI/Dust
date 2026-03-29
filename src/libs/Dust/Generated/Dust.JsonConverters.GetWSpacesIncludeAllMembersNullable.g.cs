#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWSpacesIncludeAllMembersNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.GetWSpacesIncludeAllMembers?>
    {
        /// <inheritdoc />
        public override global::Dust.GetWSpacesIncludeAllMembers? Read(
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
                        return global::Dust.GetWSpacesIncludeAllMembersExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.GetWSpacesIncludeAllMembers)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.GetWSpacesIncludeAllMembers?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.GetWSpacesIncludeAllMembers? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.GetWSpacesIncludeAllMembersExtensions.ToValueString(value.Value));
            }
        }
    }
}
