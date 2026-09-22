
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionContentPartInputAudioWithTitleType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartInputAudioWithTitleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartInputAudioWithTitleType value)
        {
            return value switch
            {
                ChatCompletionContentPartInputAudioWithTitleType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartInputAudioWithTitleType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => ChatCompletionContentPartInputAudioWithTitleType.InputAudio,
                _ => null,
            };
        }
    }
}