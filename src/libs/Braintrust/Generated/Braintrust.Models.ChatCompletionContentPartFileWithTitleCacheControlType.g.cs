
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionContentPartFileWithTitleCacheControlType
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartFileWithTitleCacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartFileWithTitleCacheControlType value)
        {
            return value switch
            {
                ChatCompletionContentPartFileWithTitleCacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartFileWithTitleCacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => ChatCompletionContentPartFileWithTitleCacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}