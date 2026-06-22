
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Clauses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConditionWhen" /> class.
        /// </summary>
        /// <param name="clauses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectScoreConditionWhen(
            global::System.Collections.Generic.IList<string> clauses)
        {
            this.Clauses = clauses ?? throw new global::System.ArgumentNullException(nameof(clauses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConditionWhen" /> class.
        /// </summary>
        public ProjectScoreConditionWhen()
        {
        }

    }
}