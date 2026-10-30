
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The ground truth value (an arbitrary, JSON serializable object) that you'd compare to `output` to determine if your `output` value is correct or not
    /// </summary>
    public sealed partial class FeedbackExperimentItemExpected
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}