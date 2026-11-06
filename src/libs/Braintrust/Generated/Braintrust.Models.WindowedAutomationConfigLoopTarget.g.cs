
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The object this automation writes to or maintains
    /// </summary>
    public sealed partial class WindowedAutomationConfigLoopTarget
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigLoopTargetTypeJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigLoopTargetType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigLoopTargetIdJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigLoopTargetId Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigLoopTarget" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigLoopTarget(
            global::Braintrust.WindowedAutomationConfigLoopTargetType type,
            global::Braintrust.WindowedAutomationConfigLoopTargetId id)
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigLoopTarget" /> class.
        /// </summary>
        public WindowedAutomationConfigLoopTarget()
        {
        }

    }
}