
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectScoreConditionWhen
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clauses")]
        public global::System.Collections.Generic.IList<string>? Clauses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subspan_clauses")]
        public global::System.Collections.Generic.IList<string>? SubspanClauses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_clauses")]
        public global::System.Collections.Generic.IList<string>? TraceClauses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConditionWhen" /> class.
        /// </summary>
        /// <param name="clauses"></param>
        /// <param name="subspanClauses"></param>
        /// <param name="traceClauses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectScoreConditionWhen(
            global::System.Collections.Generic.IList<string>? clauses,
            global::System.Collections.Generic.IList<string>? subspanClauses,
            global::System.Collections.Generic.IList<string>? traceClauses)
        {
            this.Clauses = clauses;
            this.SubspanClauses = subspanClauses;
            this.TraceClauses = traceClauses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConditionWhen" /> class.
        /// </summary>
        public ProjectScoreConditionWhen()
        {
        }

    }
}