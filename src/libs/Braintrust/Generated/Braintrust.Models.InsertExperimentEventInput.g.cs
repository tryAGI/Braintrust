
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The arguments that uniquely define a test case (an arbitrary, JSON serializable object). Later on, Braintrust will use the `input` to know whether two test cases are the same between experiments, so they should not contain experiment-specific state. A simple rule of thumb is that if you run the same experiment twice, the `input` should be identical
    /// </summary>
    public sealed partial class InsertExperimentEventInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}