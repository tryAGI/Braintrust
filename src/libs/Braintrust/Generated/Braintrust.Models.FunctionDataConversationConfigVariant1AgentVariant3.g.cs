
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionDataConversationConfigVariant1AgentVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataConversationConfigVariant1AgentVariant3TypeJsonConverter))]
        public global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataConversationConfigVariant1AgentVariant3" /> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataConversationConfigVariant1AgentVariant3(
            string uri,
            global::Braintrust.FunctionDataConversationConfigVariant1AgentVariant3Type type)
        {
            this.Type = type;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataConversationConfigVariant1AgentVariant3" /> class.
        /// </summary>
        public FunctionDataConversationConfigVariant1AgentVariant3()
        {
        }

    }
}