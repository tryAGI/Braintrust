
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WindowedAutomationConfigWindow
    {
        /// <summary>
        /// How much recent data each scheduled run covers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowSeconds { get; set; }

        /// <summary>
        /// How often the windowed automation runs: at a fixed interval or on a cron schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2> Schedule { get; set; }

        /// <summary>
        /// How far behind the present each evaluation window ends
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_delay_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EvaluationDelaySeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigWindow" /> class.
        /// </summary>
        /// <param name="windowSeconds">
        /// How much recent data each scheduled run covers
        /// </param>
        /// <param name="schedule">
        /// How often the windowed automation runs: at a fixed interval or on a cron schedule
        /// </param>
        /// <param name="evaluationDelaySeconds">
        /// How far behind the present each evaluation window ends
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigWindow(
            int windowSeconds,
            global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigWindowScheduleVariant1, global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2> schedule,
            int evaluationDelaySeconds)
        {
            this.WindowSeconds = windowSeconds;
            this.Schedule = schedule;
            this.EvaluationDelaySeconds = evaluationDelaySeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigWindow" /> class.
        /// </summary>
        public WindowedAutomationConfigWindow()
        {
        }

    }
}