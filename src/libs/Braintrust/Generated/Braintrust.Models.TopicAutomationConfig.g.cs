
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicAutomationConfig
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicAutomationConfigEventTypeJsonConverter))]
        public global::Braintrust.TopicAutomationConfigEventType EventType { get; set; }

        /// <summary>
        /// The sampling rate for topic automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingRate { get; set; }

        /// <summary>
        /// Facet functions used by the topic automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facet_functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>> FacetFunctions { get; set; }

        /// <summary>
        /// Topic map functions with optional per-topic-map filters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_map_functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation> TopicMapFunctions { get; set; }

        /// <summary>
        /// Execution scope for topic automation. Defaults to span-level execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>))]
        public global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>? Scope { get; set; }

        /// <summary>
        /// Optional data scope for topic automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicAutomationDataScopeJsonConverter))]
        public global::Braintrust.TopicAutomationDataScope? DataScope { get; set; }

        /// <summary>
        /// Optional BTQL filter applied before topic automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_filter")]
        public string? BtqlFilter { get; set; }

        /// <summary>
        /// How often to recompute topic maps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerun_seconds")]
        public double? RerunSeconds { get; set; }

        /// <summary>
        /// How much recent history to relabel after a new topic map version becomes active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relabel_overlap_seconds")]
        public double? RelabelOverlapSeconds { get; set; }

        /// <summary>
        /// Topic window used for classification coverage and initial backfill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_time_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>))]
        public global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>? BackfillTimeRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicAutomationConfig" /> class.
        /// </summary>
        /// <param name="samplingRate">
        /// The sampling rate for topic automation
        /// </param>
        /// <param name="facetFunctions">
        /// Facet functions used by the topic automation
        /// </param>
        /// <param name="topicMapFunctions">
        /// Topic map functions with optional per-topic-map filters
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="scope">
        /// Execution scope for topic automation. Defaults to span-level execution.
        /// </param>
        /// <param name="dataScope">
        /// Optional data scope for topic automation.
        /// </param>
        /// <param name="btqlFilter">
        /// Optional BTQL filter applied before topic automation.
        /// </param>
        /// <param name="rerunSeconds">
        /// How often to recompute topic maps
        /// </param>
        /// <param name="relabelOverlapSeconds">
        /// How much recent history to relabel after a new topic map version becomes active
        /// </param>
        /// <param name="backfillTimeRange">
        /// Topic window used for classification coverage and initial backfill.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicAutomationConfig(
            double samplingRate,
            global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Function, global::Braintrust.TopicAutomationConfigFacetFunctionVariant2Global>?>> facetFunctions,
            global::System.Collections.Generic.IList<global::Braintrust.TopicMapFunctionAutomation> topicMapFunctions,
            global::Braintrust.TopicAutomationConfigEventType eventType,
            global::Braintrust.AnyOf<global::Braintrust.SpanScope, global::Braintrust.TraceScope, global::Braintrust.GroupScope, object>? scope,
            global::Braintrust.TopicAutomationDataScope? dataScope,
            string? btqlFilter,
            double? rerunSeconds,
            double? relabelOverlapSeconds,
            global::Braintrust.AnyOf<string, global::Braintrust.TopicAutomationConfigBackfillTimeRange, object>? backfillTimeRange)
        {
            this.EventType = eventType;
            this.SamplingRate = samplingRate;
            this.FacetFunctions = facetFunctions ?? throw new global::System.ArgumentNullException(nameof(facetFunctions));
            this.TopicMapFunctions = topicMapFunctions ?? throw new global::System.ArgumentNullException(nameof(topicMapFunctions));
            this.Scope = scope;
            this.DataScope = dataScope;
            this.BtqlFilter = btqlFilter;
            this.RerunSeconds = rerunSeconds;
            this.RelabelOverlapSeconds = relabelOverlapSeconds;
            this.BackfillTimeRange = backfillTimeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicAutomationConfig" /> class.
        /// </summary>
        public TopicAutomationConfig()
        {
        }
    }
}