
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrossObjectInsertRequestExperiment2
    {
        /// <summary>
        /// A list of experiment events to insert
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>? Events { get; set; }

        /// <summary>
        /// A list of experiment feedback items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequestExperiment2" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of experiment events to insert
        /// </param>
        /// <param name="feedback">
        /// A list of experiment feedback items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrossObjectInsertRequestExperiment2(
            global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent>? events,
            global::System.Collections.Generic.IList<global::Braintrust.FeedbackExperimentItem>? feedback)
        {
            this.Events = events;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequestExperiment2" /> class.
        /// </summary>
        public CrossObjectInsertRequestExperiment2()
        {
        }
    }
}