
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The prompt, model, and its parameters
    /// </summary>
    public sealed partial class PromptDataNullish
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishJsonConverter))]
        public global::Braintrust.PromptBlockDataNullish? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Braintrust.PromptOptionsNullish? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parser")]
        public global::Braintrust.PromptParserNullish? Parser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_functions")]
        public global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>>? ToolFunctions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PromptDataNullishTemplateFormatJsonConverter))]
        public global::Braintrust.PromptDataNullishTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        public object? Mcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public global::Braintrust.PromptDataNullishOrigin? Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullish" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="options"></param>
        /// <param name="parser"></param>
        /// <param name="toolFunctions"></param>
        /// <param name="templateFormat"></param>
        /// <param name="mcp"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptDataNullish(
            global::Braintrust.PromptBlockDataNullish? prompt,
            global::Braintrust.PromptOptionsNullish? options,
            global::Braintrust.PromptParserNullish? parser,
            global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.PromptDataNullishToolFunctionVariant2Function, global::Braintrust.PromptDataNullishToolFunctionVariant2Global>?>>? toolFunctions,
            global::Braintrust.PromptDataNullishTemplateFormat? templateFormat,
            object? mcp,
            global::Braintrust.PromptDataNullishOrigin? origin)
        {
            this.Prompt = prompt;
            this.Options = options;
            this.Parser = parser;
            this.ToolFunctions = toolFunctions;
            this.TemplateFormat = templateFormat;
            this.Mcp = mcp;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullish" /> class.
        /// </summary>
        public PromptDataNullish()
        {
        }
    }
}