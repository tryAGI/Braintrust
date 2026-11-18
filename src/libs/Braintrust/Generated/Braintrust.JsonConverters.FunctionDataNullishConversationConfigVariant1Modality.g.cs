#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionDataNullishConversationConfigVariant1ModalityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.FunctionDataNullishConversationConfigVariant1Modality>
    {
        /// <inheritdoc />
        public override global::Braintrust.FunctionDataNullishConversationConfigVariant1Modality Read(
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
                        return global::Braintrust.FunctionDataNullishConversationConfigVariant1ModalityExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.FunctionDataNullishConversationConfigVariant1Modality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.FunctionDataNullishConversationConfigVariant1Modality);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.FunctionDataNullishConversationConfigVariant1Modality value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.FunctionDataNullishConversationConfigVariant1ModalityExtensions.ToValueString(value));
        }
    }
}
