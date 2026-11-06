
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataDecisionsQuestionVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Predicate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataDecisionsQuestionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataDecisionsQuestionVariant1Type value)
        {
            return value switch
            {
                PromptBlockDataDecisionsQuestionVariant1Type.Predicate => "predicate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataDecisionsQuestionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "predicate" => PromptBlockDataDecisionsQuestionVariant1Type.Predicate,
                _ => null,
            };
        }
    }
}