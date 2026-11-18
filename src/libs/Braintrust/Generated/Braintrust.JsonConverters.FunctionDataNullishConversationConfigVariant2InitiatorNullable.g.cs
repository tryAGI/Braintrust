#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionDataNullishConversationConfigVariant2InitiatorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.FunctionDataNullishConversationConfigVariant2Initiator?>
    {
        /// <inheritdoc />
        public override global::Braintrust.FunctionDataNullishConversationConfigVariant2Initiator? Read(
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
                        return global::Braintrust.FunctionDataNullishConversationConfigVariant2InitiatorExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.FunctionDataNullishConversationConfigVariant2Initiator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.FunctionDataNullishConversationConfigVariant2Initiator?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.FunctionDataNullishConversationConfigVariant2Initiator? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.FunctionDataNullishConversationConfigVariant2InitiatorExtensions.ToValueString(value.Value));
            }
        }
    }
}
