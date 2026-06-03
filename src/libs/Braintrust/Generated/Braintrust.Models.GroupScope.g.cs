
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Process spans/traces grouped by a field (e.g., session_id)
    /// </summary>
    public sealed partial class GroupScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.GroupScopeTypeJsonConverter))]
        public global::Braintrust.GroupScopeType Type { get; set; }

        /// <summary>
        /// Field path to group by, e.g. metadata.session_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupBy { get; set; }

        /// <summary>
        /// Maximum time range to include when constructing a group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        public double? IntervalSeconds { get; set; }

        /// <summary>
        /// Maximum number of traces to include when constructing a group (default/max: 64)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_traces")]
        public int? MaxTraces { get; set; }

        /// <summary>
        /// Which trace or traces to write grouped scorer results to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.GroupScopePlacementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.GroupScopePlacement Placement { get; set; }

        /// <summary>
        /// Optional: trigger after this many seconds of inactivity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_seconds")]
        public double? IdleSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupScope" /> class.
        /// </summary>
        /// <param name="groupBy">
        /// Field path to group by, e.g. metadata.session_id
        /// </param>
        /// <param name="placement">
        /// Which trace or traces to write grouped scorer results to
        /// </param>
        /// <param name="type"></param>
        /// <param name="intervalSeconds">
        /// Maximum time range to include when constructing a group
        /// </param>
        /// <param name="maxTraces">
        /// Maximum number of traces to include when constructing a group (default/max: 64)
        /// </param>
        /// <param name="idleSeconds">
        /// Optional: trigger after this many seconds of inactivity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupScope(
            string groupBy,
            global::Braintrust.GroupScopePlacement placement,
            global::Braintrust.GroupScopeType type,
            double? intervalSeconds,
            int? maxTraces,
            double? idleSeconds)
        {
            this.Type = type;
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.IntervalSeconds = intervalSeconds;
            this.MaxTraces = maxTraces;
            this.Placement = placement;
            this.IdleSeconds = idleSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupScope" /> class.
        /// </summary>
        public GroupScope()
        {
        }

    }
}