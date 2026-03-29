
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataParametersTypeJsonConverter))]
        public global::Braintrust.FunctionDataParametersType Type { get; set; }

        /// <summary>
        /// The parameters data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; }

        /// <summary>
        /// JSON Schema format for parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.FunctionDataParametersSchema Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataParameters" /> class.
        /// </summary>
        /// <param name="data">
        /// The parameters data
        /// </param>
        /// <param name="schema">
        /// JSON Schema format for parameters
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataParameters(
            global::System.Collections.Generic.Dictionary<string, object?> data,
            global::Braintrust.FunctionDataParametersSchema schema,
            global::Braintrust.FunctionDataParametersType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataParameters" /> class.
        /// </summary>
        public FunctionDataParameters()
        {
        }
    }
}