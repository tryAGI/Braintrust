
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProjectAutomationConfigVariant5ActionVariant1
    {
        /// <summary>
        /// The type of action to take
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PatchProjectAutomationConfigVariant5ActionVariant1TypeJsonConverter))]
        public global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type Type { get; set; }

        /// <summary>
        /// The webhook URL to send the request to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Instructions for Loop to format content sent to this destination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting_prompt")]
        public string? FormattingPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant5ActionVariant1" /> class.
        /// </summary>
        /// <param name="url">
        /// The webhook URL to send the request to
        /// </param>
        /// <param name="type">
        /// The type of action to take
        /// </param>
        /// <param name="formattingPrompt">
        /// Instructions for Loop to format content sent to this destination
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchProjectAutomationConfigVariant5ActionVariant1(
            string url,
            global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant1Type type,
            string? formattingPrompt)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.FormattingPrompt = formattingPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant5ActionVariant1" /> class.
        /// </summary>
        public PatchProjectAutomationConfigVariant5ActionVariant1()
        {
        }

    }
}