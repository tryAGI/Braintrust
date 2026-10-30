
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The argument that uniquely define an input case (an arbitrary, JSON serializable object)
    /// </summary>
    public sealed partial class InsertDatasetEventInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}