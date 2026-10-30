
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The ground truth value (an arbitrary, JSON serializable object) that you'd compare to `output` to determine if your `output` value is correct or not. Braintrust currently does not compare `output` to `expected` for you, since there are so many different ways to do that correctly. Instead, these values are just used to help you navigate your experiments while digging into analyses. However, we may later use these values to re-score outputs or fine-tune your models
    /// </summary>
    public sealed partial class ExperimentEventExpected
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}