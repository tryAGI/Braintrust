#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelParamsOpenAIModelParamsToolChoiceAutoNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?>
    {
        /// <inheritdoc />
        public override global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto? Read(
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
                        return global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAutoExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAuto? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.ModelParamsOpenAIModelParamsToolChoiceAutoExtensions.ToValueString(value.Value));
            }
        }
    }
}
