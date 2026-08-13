
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartFileWithTitleCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleCacheControlTypeJsonConverter))]
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartFileWithTitleCacheControlTtlJsonConverter))]
        public global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartFileWithTitleCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartFileWithTitleCacheControl(
            global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlType type,
            global::Braintrust.ChatCompletionContentPartFileWithTitleCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartFileWithTitleCacheControl" /> class.
        /// </summary>
        public ChatCompletionContentPartFileWithTitleCacheControl()
        {
        }

    }
}