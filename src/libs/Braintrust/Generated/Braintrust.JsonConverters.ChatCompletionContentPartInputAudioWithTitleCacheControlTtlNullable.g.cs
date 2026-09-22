#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionContentPartInputAudioWithTitleCacheControlTtlNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl?>
    {
        /// <inheritdoc />
        public override global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? Read(
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
                        return global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtlExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControlTtlExtensions.ToValueString(value.Value));
            }
        }
    }
}
