
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FacetPreprocessorIdPreprocessorInline
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FacetPreprocessorIdPreprocessorInlineTypeJsonConverter))]
        public global::Braintrust.FacetPreprocessorIdPreprocessorInlineType Type { get; set; }

        /// <summary>
        /// The complete JavaScript preprocessor implementation, including its handler.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetPreprocessorIdPreprocessorInline" /> class.
        /// </summary>
        /// <param name="code">
        /// The complete JavaScript preprocessor implementation, including its handler.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacetPreprocessorIdPreprocessorInline(
            string code,
            global::Braintrust.FacetPreprocessorIdPreprocessorInlineType type)
        {
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetPreprocessorIdPreprocessorInline" /> class.
        /// </summary>
        public FacetPreprocessorIdPreprocessorInline()
        {
        }

    }
}