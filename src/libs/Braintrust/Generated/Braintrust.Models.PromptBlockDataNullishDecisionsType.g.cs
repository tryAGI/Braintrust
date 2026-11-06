
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataNullishDecisionsType
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataNullishDecisionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataNullishDecisionsType value)
        {
            return value switch
            {
                PromptBlockDataNullishDecisionsType.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataNullishDecisionsType? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => PromptBlockDataNullishDecisionsType.Decisions,
                _ => null,
            };
        }
    }
}