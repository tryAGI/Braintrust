
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionContentPartInputAudioWithTitle
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio InputAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ChatCompletionContentPartInputAudioWithTitleTypeJsonConverter))]
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartInputAudioWithTitle" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartInputAudioWithTitle(
            global::Braintrust.ChatCompletionContentPartInputAudioWithTitleInputAudio inputAudio,
            global::Braintrust.ChatCompletionContentPartInputAudioWithTitleType type,
            global::Braintrust.ChatCompletionContentPartInputAudioWithTitleCacheControl? cacheControl)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartInputAudioWithTitle" /> class.
        /// </summary>
        public ChatCompletionContentPartInputAudioWithTitle()
        {
        }

    }
}