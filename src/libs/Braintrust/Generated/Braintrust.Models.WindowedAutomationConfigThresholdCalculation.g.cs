
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WindowedAutomationConfigThresholdCalculation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdCalculationTypeJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigThresholdCalculationType Type { get; set; }

        /// <summary>
        /// A project-scoped BTQL or SQL query without runtime-owned evaluation time bounds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BtqlQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdCalculation" /> class.
        /// </summary>
        /// <param name="btqlQuery">
        /// A project-scoped BTQL or SQL query without runtime-owned evaluation time bounds
        /// </param>
        /// <param name="output"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigThresholdCalculation(
            string btqlQuery,
            global::Braintrust.WindowedAutomationConfigThresholdCalculationOutput output,
            global::Braintrust.WindowedAutomationConfigThresholdCalculationType type)
        {
            this.Type = type;
            this.BtqlQuery = btqlQuery ?? throw new global::System.ArgumentNullException(nameof(btqlQuery));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdCalculation" /> class.
        /// </summary>
        public WindowedAutomationConfigThresholdCalculation()
        {
        }

    }
}