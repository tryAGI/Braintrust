
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionContentPartImageWithTitleCacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartImageWithTitleCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartImageWithTitleCacheControlType value)
        {
            return value switch
            {
                ChatCompletionContentPartImageWithTitleCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartImageWithTitleCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => ChatCompletionContentPartImageWithTitleCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}