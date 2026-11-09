
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WindowedAutomationConfigLoopDigest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writing_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigLoopDigestWritingStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigLoopDigestWritingStyle WritingStyle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigLoopDigest" /> class.
        /// </summary>
        /// <param name="writingStyle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigLoopDigest(
            global::Braintrust.WindowedAutomationConfigLoopDigestWritingStyle writingStyle)
        {
            this.WritingStyle = writingStyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigLoopDigest" /> class.
        /// </summary>
        public WindowedAutomationConfigLoopDigest()
        {
        }

    }
}