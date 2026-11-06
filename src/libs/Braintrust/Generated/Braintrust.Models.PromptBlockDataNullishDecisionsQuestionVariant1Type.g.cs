
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataNullishDecisionsQuestionVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Predicate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataNullishDecisionsQuestionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataNullishDecisionsQuestionVariant1Type value)
        {
            return value switch
            {
                PromptBlockDataNullishDecisionsQuestionVariant1Type.Predicate => "predicate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataNullishDecisionsQuestionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "predicate" => PromptBlockDataNullishDecisionsQuestionVariant1Type.Predicate,
                _ => null,
            };
        }
    }
}