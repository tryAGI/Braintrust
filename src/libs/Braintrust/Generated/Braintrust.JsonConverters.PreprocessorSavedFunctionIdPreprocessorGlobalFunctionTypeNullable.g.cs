#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PreprocessorSavedFunctionIdPreprocessorGlobalFunctionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobalFunctionType?>
    {
        /// <inheritdoc />
        public override global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobalFunctionType? Read(
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
                        return global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobalFunctionTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobalFunctionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobalFunctionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobalFunctionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.PreprocessorSavedFunctionIdPreprocessorGlobalFunctionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
