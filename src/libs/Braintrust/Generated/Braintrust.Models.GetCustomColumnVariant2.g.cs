
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The table variant the custom column applies to. If omitted, defaults to the nonempty `subtype`, or otherwise to `object_type`. Set `experiment_list` explicitly to target the experiments list instead of experiment details. Use the same scope when creating and listing columns
    /// </summary>
    public sealed partial class GetCustomColumnVariant2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}