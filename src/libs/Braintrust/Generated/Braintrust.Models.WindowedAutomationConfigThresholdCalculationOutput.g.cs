
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WindowedAutomationConfigThresholdCalculationOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdCalculationOutputTypeJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType Type { get; set; }

        /// <summary>
        /// The numeric result column produced by the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValueColumn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdCalculationOutput" /> class.
        /// </summary>
        /// <param name="valueColumn">
        /// The numeric result column produced by the query
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigThresholdCalculationOutput(
            string valueColumn,
            global::Braintrust.WindowedAutomationConfigThresholdCalculationOutputType type)
        {
            this.Type = type;
            this.ValueColumn = valueColumn ?? throw new global::System.ArgumentNullException(nameof(valueColumn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdCalculationOutput" /> class.
        /// </summary>
        public WindowedAutomationConfigThresholdCalculationOutput()
        {
        }

    }
}