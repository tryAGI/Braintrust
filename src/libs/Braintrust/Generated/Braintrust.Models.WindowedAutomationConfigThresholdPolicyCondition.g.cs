
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WindowedAutomationConfigThresholdPolicyCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyConditionTypeJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator Operator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdPolicyCondition" /> class.
        /// </summary>
        /// <param name="operator"></param>
        /// <param name="threshold"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigThresholdPolicyCondition(
            global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionOperator @operator,
            double threshold,
            global::Braintrust.WindowedAutomationConfigThresholdPolicyConditionType type)
        {
            this.Type = type;
            this.Operator = @operator;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdPolicyCondition" /> class.
        /// </summary>
        public WindowedAutomationConfigThresholdPolicyCondition()
        {
        }

    }
}