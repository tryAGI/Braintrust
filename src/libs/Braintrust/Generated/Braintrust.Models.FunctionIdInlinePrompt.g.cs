
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Inline prompt definition
    /// </summary>
    public sealed partial class FunctionIdInlinePrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.PromptData InlinePrompt { get; set; }

        /// <summary>
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionTypeEnumJsonConverter))]
        public global::Braintrust.FunctionTypeEnum? FunctionType { get; set; }

        /// <summary>
        /// The name of the inline prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlinePrompt" /> class.
        /// </summary>
        /// <param name="inlinePrompt"></param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </param>
        /// <param name="name">
        /// The name of the inline prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionIdInlinePrompt(
            global::Braintrust.PromptData inlinePrompt,
            global::Braintrust.FunctionTypeEnum? functionType,
            string? name)
        {
            this.InlinePrompt = inlinePrompt ?? throw new global::System.ArgumentNullException(nameof(inlinePrompt));
            this.FunctionType = functionType;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlinePrompt" /> class.
        /// </summary>
        public FunctionIdInlinePrompt()
        {
        }
    }
}