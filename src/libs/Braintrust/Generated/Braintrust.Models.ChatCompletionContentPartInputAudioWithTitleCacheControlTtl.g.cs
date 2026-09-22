
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionContentPartInputAudioWithTitleCacheControlTtl
    {
        /// <summary>
        ///
        /// </summary>
        x1h,
        /// <summary>
        ///
        /// </summary>
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartInputAudioWithTitleCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartInputAudioWithTitleCacheControlTtl value)
        {
            return value switch
            {
                ChatCompletionContentPartInputAudioWithTitleCacheControlTtl.x1h => "1h",
                ChatCompletionContentPartInputAudioWithTitleCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartInputAudioWithTitleCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatCompletionContentPartInputAudioWithTitleCacheControlTtl.x1h,
                "5m" => ChatCompletionContentPartInputAudioWithTitleCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}