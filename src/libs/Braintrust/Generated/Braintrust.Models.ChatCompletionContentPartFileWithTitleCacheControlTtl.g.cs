
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionContentPartFileWithTitleCacheControlTtl
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
    public static class ChatCompletionContentPartFileWithTitleCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartFileWithTitleCacheControlTtl value)
        {
            return value switch
            {
                ChatCompletionContentPartFileWithTitleCacheControlTtl.x1h => "1h",
                ChatCompletionContentPartFileWithTitleCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartFileWithTitleCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatCompletionContentPartFileWithTitleCacheControlTtl.x1h,
                "5m" => ChatCompletionContentPartFileWithTitleCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}