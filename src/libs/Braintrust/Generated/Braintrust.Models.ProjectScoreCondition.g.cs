
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectScoreCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.ProjectScoreConditionWhen When { get; set; }

        /// <summary>
        /// Default Value: hidden
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ProjectScoreConditionBehaviorJsonConverter))]
        public global::Braintrust.ProjectScoreConditionBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreCondition" /> class.
        /// </summary>
        /// <param name="when"></param>
        /// <param name="behavior">
        /// Default Value: hidden
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectScoreCondition(
            global::Braintrust.ProjectScoreConditionWhen when,
            global::Braintrust.ProjectScoreConditionBehavior? behavior)
        {
            this.When = when ?? throw new global::System.ArgumentNullException(nameof(when));
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreCondition" /> class.
        /// </summary>
        public ProjectScoreCondition()
        {
        }

    }
}