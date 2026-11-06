
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataDecisionsQuestionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataDecisionsQuestionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataDecisionsQuestionVariant3Type value)
        {
            return value switch
            {
                PromptBlockDataDecisionsQuestionVariant3Type.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataDecisionsQuestionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "score" => PromptBlockDataDecisionsQuestionVariant3Type.Score,
                _ => null,
            };
        }
    }
}