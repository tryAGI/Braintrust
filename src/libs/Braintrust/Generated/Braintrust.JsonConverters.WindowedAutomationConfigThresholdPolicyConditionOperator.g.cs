#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class WindowedAutomationConfigThresholdPolicyConditionOperatorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator>
    {
        /// <inheritdoc />
        public override global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator Read(
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
                        return global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperatorExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperatorExtensions.ToValueString(value));
        }
    }
}
