
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionContentPartTextCacheControlTtl
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
    public static class ChatCompletionContentPartTextCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartTextCacheControlTtl value)
        {
            return value switch
            {
                ChatCompletionContentPartTextCacheControlTtl.x1h => "1h",
                ChatCompletionContentPartTextCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartTextCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatCompletionContentPartTextCacheControlTtl.x1h,
                "5m" => ChatCompletionContentPartTextCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}