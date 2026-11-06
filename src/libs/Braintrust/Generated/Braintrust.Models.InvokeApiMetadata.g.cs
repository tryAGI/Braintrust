
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Any relevant metadata to log on the span. For prompts, this is available as the `metadata` template variable. For code functions, this is passed through hooks and is not added to `input`.
    /// </summary>
    public sealed partial class InvokeApiMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}