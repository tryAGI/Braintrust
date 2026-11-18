#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionDataNullishConversationConfigVariant2ModalityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.FunctionDataNullishConversationConfigVariant2Modality?>
    {
        /// <inheritdoc />
        public override global::Braintrust.FunctionDataNullishConversationConfigVariant2Modality? Read(
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
                        return global::Braintrust.FunctionDataNullishConversationConfigVariant2ModalityExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.FunctionDataNullishConversationConfigVariant2Modality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.FunctionDataNullishConversationConfigVariant2Modality?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.FunctionDataNullishConversationConfigVariant2Modality? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.FunctionDataNullishConversationConfigVariant2ModalityExtensions.ToValueString(value.Value));
            }
        }
    }
}
