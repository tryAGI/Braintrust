
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartImageWithTitleCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleCacheControlTypeJsonConverter))]
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartImageWithTitleCacheControlTtlJsonConverter))]
        public global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageWithTitleCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartImageWithTitleCacheControl(
            global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlType type,
            global::Braintrust.ChatCompletionContentPartImageWithTitleCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartImageWithTitleCacheControl" /> class.
        /// </summary>
        public ChatCompletionContentPartImageWithTitleCacheControl()
        {
        }

    }
}