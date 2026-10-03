
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelParamsOpenAIModelParamsChatTemplateKwargs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_thinking")]
        public bool? EnableThinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsOpenAIModelParamsChatTemplateKwargs" /> class.
        /// </summary>
        /// <param name="enableThinking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelParamsOpenAIModelParamsChatTemplateKwargs(
            bool? enableThinking)
        {
            this.EnableThinking = enableThinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsOpenAIModelParamsChatTemplateKwargs" /> class.
        /// </summary>
        public ModelParamsOpenAIModelParamsChatTemplateKwargs()
        {
        }

    }
}