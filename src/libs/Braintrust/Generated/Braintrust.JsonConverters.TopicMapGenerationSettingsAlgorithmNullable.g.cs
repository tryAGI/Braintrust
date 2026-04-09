#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopicMapGenerationSettingsAlgorithmNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.TopicMapGenerationSettingsAlgorithm?>
    {
        /// <inheritdoc />
        public override global::Braintrust.TopicMapGenerationSettingsAlgorithm? Read(
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
                        return global::Braintrust.TopicMapGenerationSettingsAlgorithmExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.TopicMapGenerationSettingsAlgorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.TopicMapGenerationSettingsAlgorithm?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.TopicMapGenerationSettingsAlgorithm? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.TopicMapGenerationSettingsAlgorithmExtensions.ToValueString(value.Value));
            }
        }
    }
}
