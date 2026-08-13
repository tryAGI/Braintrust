
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionContentPartImageWithTitleCacheControlTtl
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
    public static class ChatCompletionContentPartImageWithTitleCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageWithTitleCacheControlTtl value)
        {
            return value switch
            {
                ChatCompletionContentPartImageWithTitleCacheControlTtl.x1h => "1h",
                ChatCompletionContentPartImageWithTitleCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageWithTitleCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatCompletionContentPartImageWithTitleCacheControlTtl.x1h,
                "5m" => ChatCompletionContentPartImageWithTitleCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}