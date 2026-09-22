
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionContentPartInputAudioWithTitleInputAudioFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartInputAudioWithTitleInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartInputAudioWithTitleInputAudioFormat value)
        {
            return value switch
            {
                ChatCompletionContentPartInputAudioWithTitleInputAudioFormat.Mp3 => "mp3",
                ChatCompletionContentPartInputAudioWithTitleInputAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartInputAudioWithTitleInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => ChatCompletionContentPartInputAudioWithTitleInputAudioFormat.Mp3,
                "wav" => ChatCompletionContentPartInputAudioWithTitleInputAudioFormat.Wav,
                _ => null,
            };
        }
    }
}