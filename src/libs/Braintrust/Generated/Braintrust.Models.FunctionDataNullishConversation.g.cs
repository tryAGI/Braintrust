
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// A task function that runs a conversation between an agent and a simulated user.
    /// </summary>
    public sealed partial class FunctionDataNullishConversation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataNullishConversationTypeJsonConverter))]
        public global::Braintrust.FunctionDataNullishConversationType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.FunctionDataNullishConversationConfigVariant1, global::Braintrust.FunctionDataNullishConversationConfigVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishConversationConfigVariant1, global::Braintrust.FunctionDataNullishConversationConfigVariant2> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishConversation" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataNullishConversation(
            global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishConversationConfigVariant1, global::Braintrust.FunctionDataNullishConversationConfigVariant2> config,
            global::Braintrust.FunctionDataNullishConversationType type)
        {
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishConversation" /> class.
        /// </summary>
        public FunctionDataNullishConversation()
        {
        }

    }
}