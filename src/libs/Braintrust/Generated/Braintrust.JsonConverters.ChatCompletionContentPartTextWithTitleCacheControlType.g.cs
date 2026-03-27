#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionContentPartTextWithTitleCacheControlTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType>
    {
        /// <inheritdoc />
        public override global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType Read(
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
                        return global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.ChatCompletionContentPartTextWithTitleCacheControlTypeExtensions.ToValueString(value));
        }
    }
}
