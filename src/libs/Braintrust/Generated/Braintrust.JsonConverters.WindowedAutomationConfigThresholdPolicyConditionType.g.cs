#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class WindowedAutomationConfigThresholdPolicyConditionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType>
    {
        /// <inheritdoc />
        public override global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType Read(
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
                        return global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionTypeExtensions.ToValueString(value));
        }
    }
}
