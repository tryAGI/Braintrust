
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicDigestAutomationConfig
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicDigestAutomationConfigEventTypeJsonConverter))]
        public global::Braintrust.TopicDigestAutomationConfigEventType EventType { get; set; }

        /// <summary>
        /// Whether the automation is active or paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AutomationStatusJsonConverter))]
        public global::Braintrust.AutomationStatus? Status { get; set; }

        /// <summary>
        /// How much recent history to include in each digest<br/>
        /// Default Value: 86400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_seconds")]
        public int? WindowSeconds { get; set; }

        /// <summary>
        /// Minutes after midnight UTC when the digest should be sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time_minutes_utc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScheduledTimeMinutesUtc { get; set; }

        /// <summary>
        /// The Slack action to take when the digest is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.TopicDigestAutomationConfigAction Action { get; set; }

        /// <summary>
        /// Optional topic map function IDs to include in the digest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_map_function_ids")]
        public global::System.Collections.Generic.IList<string>? TopicMapFunctionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDigestAutomationConfig" /> class.
        /// </summary>
        /// <param name="scheduledTimeMinutesUtc">
        /// Minutes after midnight UTC when the digest should be sent
        /// </param>
        /// <param name="action">
        /// The Slack action to take when the digest is sent
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="status">
        /// Whether the automation is active or paused.
        /// </param>
        /// <param name="windowSeconds">
        /// How much recent history to include in each digest<br/>
        /// Default Value: 86400
        /// </param>
        /// <param name="topicMapFunctionIds">
        /// Optional topic map function IDs to include in the digest
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDigestAutomationConfig(
            int scheduledTimeMinutesUtc,
            global::Braintrust.TopicDigestAutomationConfigAction action,
            global::Braintrust.TopicDigestAutomationConfigEventType eventType,
            global::Braintrust.AutomationStatus? status,
            int? windowSeconds,
            global::System.Collections.Generic.IList<string>? topicMapFunctionIds)
        {
            this.EventType = eventType;
            this.Status = status;
            this.WindowSeconds = windowSeconds;
            this.ScheduledTimeMinutesUtc = scheduledTimeMinutesUtc;
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.TopicMapFunctionIds = topicMapFunctionIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDigestAutomationConfig" /> class.
        /// </summary>
        public TopicDigestAutomationConfig()
        {
        }

    }
}