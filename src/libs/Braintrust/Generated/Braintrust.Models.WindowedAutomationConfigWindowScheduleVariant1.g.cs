
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WindowedAutomationConfigWindowScheduleVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigWindowScheduleVariant1TypeJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type Type { get; set; }

        /// <summary>
        /// How often the automation runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EvaluationIntervalSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigWindowScheduleVariant1" /> class.
        /// </summary>
        /// <param name="evaluationIntervalSeconds">
        /// How often the automation runs
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigWindowScheduleVariant1(
            int evaluationIntervalSeconds,
            global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1Type type)
        {
            this.Type = type;
            this.EvaluationIntervalSeconds = evaluationIntervalSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigWindowScheduleVariant1" /> class.
        /// </summary>
        public WindowedAutomationConfigWindowScheduleVariant1()
        {
        }

    }
}