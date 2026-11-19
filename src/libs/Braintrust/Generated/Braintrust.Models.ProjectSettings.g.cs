
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectSettings
    {
        /// <summary>
        /// The key used to join two experiments (defaults to `input`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_key")]
        public string? ComparisonKey { get; set; }

        /// <summary>
        /// The id of the experiment to use as the default baseline for comparisons
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_experiment_id")]
        public global::System.Guid? BaselineExperimentId { get; set; }

        /// <summary>
        /// The order of the fields to display in the trace view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanFieldOrder")]
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsSpanFieldOrderItem>? SpanFieldOrder { get; set; }

        /// <summary>
        /// The remote eval sources to use for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_eval_sources")]
        public global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsRemoteEvalSource>? RemoteEvalSources { get; set; }

        /// <summary>
        /// If true, disable real-time queries for this project. This can improve query performance for high-volume logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_realtime_queries")]
        public bool? DisableRealtimeQueries { get; set; }

        /// <summary>
        /// If true, use metrics.start rather than created for monitor chart time bucket dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitor_charts_use_metrics_start")]
        public bool? MonitorChartsUseMetricsStart { get; set; }

        /// <summary>
        /// If true, enable the agent insights dashboard for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coding_agent_insights_dashboard")]
        public bool? CodingAgentInsightsDashboard { get; set; }

        /// <summary>
        /// If true, hide peer review scores, comments, and aggregate results from reviewers without project update permissions until they submit their own review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blind_reviews")]
        public bool? BlindReviews { get; set; }

        /// <summary>
        /// If true, automatically complete a review after every assigned reviewer fills all human review scores visible to them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_all_human_review_scores")]
        public bool? RequireAllHumanReviewScores { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id_fields")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? UserIdFields { get; set; }

        /// <summary>
        /// Project-wide Slack user or agent and prompt for Pattern alert threads. Applies only to destinations in the selected workspace. Unset or null disables mentions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_alert_mention")]
        public global::Braintrust.ProjectSettingsPatternAlertMention? PatternAlertMention { get; set; }

        /// <summary>
        /// Project-wide Slack, webhook, and PagerDuty destinations for new and reactivated Pattern alerts. An empty array disables alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_alert_destinations")]
        public global::System.Collections.Generic.IList<global::Braintrust.OneOf<global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1, global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2, global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3>>? PatternAlertDestinations { get; set; }

        /// <summary>
        /// Lowest severity that sends Pattern alerts: `low`, `medium`, or `high`. New and reactivated Patterns below it don't send alerts, and raising an active Pattern's severity to it or above sends one. Patterns without a severity count as low. Informational Patterns follow `pattern_alert_informational` instead. Unset or null uses medium.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_alert_min_severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ProjectSettingsPatternAlertMinSeverityJsonConverter))]
        public global::Braintrust.ProjectSettingsPatternAlertMinSeverity? PatternAlertMinSeverity { get; set; }

        /// <summary>
        /// Whether new and reactivated informational Patterns send alerts, independent of `pattern_alert_min_severity`. Unset or null sends them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_alert_informational")]
        public bool? PatternAlertInformational { get; set; }

        /// <summary>
        /// Patterns rubric categories this project turned off. Patterns doesn't look for or assign them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_excluded_categories")]
        public global::System.Collections.Generic.IList<string>? PatternExcludedCategories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id_fields")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? SessionIdFields { get; set; }

        /// <summary>
        /// Default preprocessor for this project. When set, functions that use preprocessors will use this instead of their built-in default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_preprocessor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.NullableSavedFunctionIdJsonConverter))]
        public global::Braintrust.NullableSavedFunctionId? DefaultPreprocessor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettings" /> class.
        /// </summary>
        /// <param name="comparisonKey">
        /// The key used to join two experiments (defaults to `input`)
        /// </param>
        /// <param name="baselineExperimentId">
        /// The id of the experiment to use as the default baseline for comparisons
        /// </param>
        /// <param name="spanFieldOrder">
        /// The order of the fields to display in the trace view
        /// </param>
        /// <param name="remoteEvalSources">
        /// The remote eval sources to use for the project
        /// </param>
        /// <param name="disableRealtimeQueries">
        /// If true, disable real-time queries for this project. This can improve query performance for high-volume logs.
        /// </param>
        /// <param name="monitorChartsUseMetricsStart">
        /// If true, use metrics.start rather than created for monitor chart time bucket dimensions.
        /// </param>
        /// <param name="codingAgentInsightsDashboard">
        /// If true, enable the agent insights dashboard for this project.
        /// </param>
        /// <param name="blindReviews">
        /// If true, hide peer review scores, comments, and aggregate results from reviewers without project update permissions until they submit their own review.
        /// </param>
        /// <param name="requireAllHumanReviewScores">
        /// If true, automatically complete a review after every assigned reviewer fills all human review scores visible to them.
        /// </param>
        /// <param name="userIdFields"></param>
        /// <param name="patternAlertMention">
        /// Project-wide Slack user or agent and prompt for Pattern alert threads. Applies only to destinations in the selected workspace. Unset or null disables mentions.
        /// </param>
        /// <param name="patternAlertDestinations">
        /// Project-wide Slack, webhook, and PagerDuty destinations for new and reactivated Pattern alerts. An empty array disables alerts.
        /// </param>
        /// <param name="patternAlertMinSeverity">
        /// Lowest severity that sends Pattern alerts: `low`, `medium`, or `high`. New and reactivated Patterns below it don't send alerts, and raising an active Pattern's severity to it or above sends one. Patterns without a severity count as low. Informational Patterns follow `pattern_alert_informational` instead. Unset or null uses medium.
        /// </param>
        /// <param name="patternAlertInformational">
        /// Whether new and reactivated informational Patterns send alerts, independent of `pattern_alert_min_severity`. Unset or null sends them.
        /// </param>
        /// <param name="patternExcludedCategories">
        /// Patterns rubric categories this project turned off. Patterns doesn't look for or assign them.
        /// </param>
        /// <param name="sessionIdFields"></param>
        /// <param name="defaultPreprocessor">
        /// Default preprocessor for this project. When set, functions that use preprocessors will use this instead of their built-in default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSettings(
            string? comparisonKey,
            global::System.Guid? baselineExperimentId,
            global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsSpanFieldOrderItem>? spanFieldOrder,
            global::System.Collections.Generic.IList<global::Braintrust.ProjectSettingsRemoteEvalSource>? remoteEvalSources,
            bool? disableRealtimeQueries,
            bool? monitorChartsUseMetricsStart,
            bool? codingAgentInsightsDashboard,
            bool? blindReviews,
            bool? requireAllHumanReviewScores,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? userIdFields,
            global::Braintrust.ProjectSettingsPatternAlertMention? patternAlertMention,
            global::System.Collections.Generic.IList<global::Braintrust.OneOf<global::Braintrust.ProjectSettingsPatternAlertDestinationVariant1, global::Braintrust.ProjectSettingsPatternAlertDestinationVariant2, global::Braintrust.ProjectSettingsPatternAlertDestinationVariant3>>? patternAlertDestinations,
            global::Braintrust.ProjectSettingsPatternAlertMinSeverity? patternAlertMinSeverity,
            bool? patternAlertInformational,
            global::System.Collections.Generic.IList<string>? patternExcludedCategories,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? sessionIdFields,
            global::Braintrust.NullableSavedFunctionId? defaultPreprocessor)
        {
            this.ComparisonKey = comparisonKey;
            this.BaselineExperimentId = baselineExperimentId;
            this.SpanFieldOrder = spanFieldOrder;
            this.RemoteEvalSources = remoteEvalSources;
            this.DisableRealtimeQueries = disableRealtimeQueries;
            this.MonitorChartsUseMetricsStart = monitorChartsUseMetricsStart;
            this.CodingAgentInsightsDashboard = codingAgentInsightsDashboard;
            this.BlindReviews = blindReviews;
            this.RequireAllHumanReviewScores = requireAllHumanReviewScores;
            this.UserIdFields = userIdFields;
            this.PatternAlertMention = patternAlertMention;
            this.PatternAlertDestinations = patternAlertDestinations;
            this.PatternAlertMinSeverity = patternAlertMinSeverity;
            this.PatternAlertInformational = patternAlertInformational;
            this.PatternExcludedCategories = patternExcludedCategories;
            this.SessionIdFields = sessionIdFields;
            this.DefaultPreprocessor = defaultPreprocessor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettings" /> class.
        /// </summary>
        public ProjectSettings()
        {
        }

    }
}