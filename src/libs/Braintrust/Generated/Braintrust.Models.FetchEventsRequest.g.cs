
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FetchEventsRequest
    {
        /// <summary>
        /// Limit the number of traces fetched<br/>
        /// Fetch queries may be paginated if the total result size is expected to be large (e.g. project_logs which accumulate over a long time). Note that fetch queries only support pagination in descending time order (from latest to earliest `_xact_id`). Furthermore, later pages may return rows which showed up in earlier pages, except with an earlier `_xact_id`. This happens because pagination occurs over the whole version history of the event log. You will most likely want to exclude any such duplicate, outdated rows (by `id`) from your combined result set.<br/>
        /// The `limit` parameter controls the number of full traces to return. So you may end up with more individual rows than the specified limit if you are fetching events containing traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// An opaque string to be used as a cursor for the next page of results, in order from latest to earliest.<br/>
        /// The string can be obtained directly from the `cursor` property of the previous fetch query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_xact_id")]
        public string? MaxXactId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_root_span_id")]
        public string? MaxRootSpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchEventsRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Limit the number of traces fetched<br/>
        /// Fetch queries may be paginated if the total result size is expected to be large (e.g. project_logs which accumulate over a long time). Note that fetch queries only support pagination in descending time order (from latest to earliest `_xact_id`). Furthermore, later pages may return rows which showed up in earlier pages, except with an earlier `_xact_id`. This happens because pagination occurs over the whole version history of the event log. You will most likely want to exclude any such duplicate, outdated rows (by `id`) from your combined result set.<br/>
        /// The `limit` parameter controls the number of full traces to return. So you may end up with more individual rows than the specified limit if you are fetching events containing traces.
        /// </param>
        /// <param name="cursor">
        /// An opaque string to be used as a cursor for the next page of results, in order from latest to earliest.<br/>
        /// The string can be obtained directly from the `cursor` property of the previous fetch query
        /// </param>
        /// <param name="maxXactId"></param>
        /// <param name="maxRootSpanId"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchEventsRequest(
            int? limit,
            string? cursor,
            string? maxXactId,
            string? maxRootSpanId,
            string? version)
        {
            this.Limit = limit;
            this.Cursor = cursor;
            this.MaxXactId = maxXactId;
            this.MaxRootSpanId = maxRootSpanId;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchEventsRequest" /> class.
        /// </summary>
        public FetchEventsRequest()
        {
        }

    }
}