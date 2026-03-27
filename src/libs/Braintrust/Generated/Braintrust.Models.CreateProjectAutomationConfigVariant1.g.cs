
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant1
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeJsonConverter))]
        public global::Braintrust.CreateProjectAutomationConfigVariant1EventType EventType { get; set; }

        /// <summary>
        /// BTQL filter to identify rows for the automation rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BtqlFilter { get; set; }

        /// <summary>
        /// Perform the triggered action at most once in this interval of seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IntervalSeconds { get; set; }

        /// <summary>
        /// The action to take when the automation rule is triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2> Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant1" /> class.
        /// </summary>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="btqlFilter">
        /// BTQL filter to identify rows for the automation rule
        /// </param>
        /// <param name="intervalSeconds">
        /// Perform the triggered action at most once in this interval of seconds
        /// </param>
        /// <param name="action">
        /// The action to take when the automation rule is triggered
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectAutomationConfigVariant1(
            string btqlFilter,
            double intervalSeconds,
            global::Braintrust.OneOf<global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant1, global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2> action,
            global::Braintrust.CreateProjectAutomationConfigVariant1EventType eventType)
        {
            this.BtqlFilter = btqlFilter ?? throw new global::System.ArgumentNullException(nameof(btqlFilter));
            this.IntervalSeconds = intervalSeconds;
            this.Action = action;
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant1" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant1()
        {
        }
    }
}