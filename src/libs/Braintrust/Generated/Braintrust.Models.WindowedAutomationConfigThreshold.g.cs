
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Optional calculation and lifecycle policy that gate scheduled delivery
    /// </summary>
    public sealed partial class WindowedAutomationConfigThreshold
    {
        /// <summary>
        /// The calculation evaluated for each window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigThresholdCalculation Calculation { get; set; }

        /// <summary>
        /// The lifecycle policy applied to each calculation result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigThresholdPolicy Policy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThreshold" /> class.
        /// </summary>
        /// <param name="calculation">
        /// The calculation evaluated for each window
        /// </param>
        /// <param name="policy">
        /// The lifecycle policy applied to each calculation result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigThreshold(
            global::Braintrust.WindowedAutomationConfigThresholdCalculation calculation,
            global::Braintrust.WindowedAutomationConfigThresholdPolicy policy)
        {
            this.Calculation = calculation ?? throw new global::System.ArgumentNullException(nameof(calculation));
            this.Policy = policy ?? throw new global::System.ArgumentNullException(nameof(policy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThreshold" /> class.
        /// </summary>
        public WindowedAutomationConfigThreshold()
        {
        }

    }
}