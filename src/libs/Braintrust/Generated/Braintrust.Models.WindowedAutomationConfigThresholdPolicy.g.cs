
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The lifecycle policy applied to each calculation result
    /// </summary>
    public sealed partial class WindowedAutomationConfigThresholdPolicy
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition Condition { get; set; }

        /// <summary>
        /// How long the condition must remain breached before firing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingSeconds { get; set; }

        /// <summary>
        /// How the lifecycle changes when the calculation returns no data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_data_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigThresholdPolicyNoDataBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior NoDataBehavior { get; set; }

        /// <summary>
        /// Optional reminder interval while the automation is firing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renotify_interval_seconds")]
        public int? RenotifyIntervalSeconds { get; set; }

        /// <summary>
        /// Whether to deliver actions when a firing automation recovers<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notify_on_recovery")]
        public bool? NotifyOnRecovery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdPolicy" /> class.
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="pendingSeconds">
        /// How long the condition must remain breached before firing
        /// </param>
        /// <param name="noDataBehavior">
        /// How the lifecycle changes when the calculation returns no data
        /// </param>
        /// <param name="renotifyIntervalSeconds">
        /// Optional reminder interval while the automation is firing
        /// </param>
        /// <param name="notifyOnRecovery">
        /// Whether to deliver actions when a firing automation recovers<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigThresholdPolicy(
            global::Braintrust.WindowedAutomationConfigThresholdPolicyCondition condition,
            int pendingSeconds,
            global::Braintrust.WindowedAutomationConfigThresholdPolicyNoDataBehavior noDataBehavior,
            int? renotifyIntervalSeconds,
            bool? notifyOnRecovery)
        {
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.PendingSeconds = pendingSeconds;
            this.NoDataBehavior = noDataBehavior;
            this.RenotifyIntervalSeconds = renotifyIntervalSeconds;
            this.NotifyOnRecovery = notifyOnRecovery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigThresholdPolicy" /> class.
        /// </summary>
        public WindowedAutomationConfigThresholdPolicy()
        {
        }

    }
}