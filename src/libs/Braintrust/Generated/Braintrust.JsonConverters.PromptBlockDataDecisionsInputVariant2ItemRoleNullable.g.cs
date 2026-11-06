#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptBlockDataDecisionsInputVariant2ItemRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole?>
    {
        /// <inheritdoc />
        public override global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole? Read(
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
                        return global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRoleExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.PromptBlockDataDecisionsInputVariant2ItemRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
