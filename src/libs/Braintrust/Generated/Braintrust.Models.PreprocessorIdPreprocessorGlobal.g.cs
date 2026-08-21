
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreprocessorIdPreprocessorGlobal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PreprocessorIdPreprocessorGlobalTypeJsonConverter))]
        public global::Braintrust.PreprocessorIdPreprocessorGlobalType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of global function. Defaults to 'preprocessor'.<br/>
        /// Default Value: preprocessor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PreprocessorIdPreprocessorGlobalFunctionTypeJsonConverter))]
        public global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType? FunctionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreprocessorIdPreprocessorGlobal" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'preprocessor'.<br/>
        /// Default Value: preprocessor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreprocessorIdPreprocessorGlobal(
            string name,
            global::Braintrust.PreprocessorIdPreprocessorGlobalType type,
            global::Braintrust.PreprocessorIdPreprocessorGlobalFunctionType? functionType)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionType = functionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreprocessorIdPreprocessorGlobal" /> class.
        /// </summary>
        public PreprocessorIdPreprocessorGlobal()
        {
        }

    }
}