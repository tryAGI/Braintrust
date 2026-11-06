
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataNullishDecisionsQuestionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataNullishDecisionsQuestionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataNullishDecisionsQuestionVariant2Type value)
        {
            return value switch
            {
                PromptBlockDataNullishDecisionsQuestionVariant2Type.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataNullishDecisionsQuestionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "choice" => PromptBlockDataNullishDecisionsQuestionVariant2Type.Choice,
                _ => null,
            };
        }
    }
}