
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataDecisionsQuestionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataDecisionsQuestionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataDecisionsQuestionVariant2Type value)
        {
            return value switch
            {
                PromptBlockDataDecisionsQuestionVariant2Type.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataDecisionsQuestionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "choice" => PromptBlockDataDecisionsQuestionVariant2Type.Choice,
                _ => null,
            };
        }
    }
}