
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataNullishDecisionsInputVariant2ItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockDataNullishDecisionsInputVariant2ItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataNullishDecisionsInputVariant2ItemRole value)
        {
            return value switch
            {
                PromptBlockDataNullishDecisionsInputVariant2ItemRole.Assistant => "assistant",
                PromptBlockDataNullishDecisionsInputVariant2ItemRole.Developer => "developer",
                PromptBlockDataNullishDecisionsInputVariant2ItemRole.System => "system",
                PromptBlockDataNullishDecisionsInputVariant2ItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataNullishDecisionsInputVariant2ItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => PromptBlockDataNullishDecisionsInputVariant2ItemRole.Assistant,
                "developer" => PromptBlockDataNullishDecisionsInputVariant2ItemRole.Developer,
                "system" => PromptBlockDataNullishDecisionsInputVariant2ItemRole.System,
                "user" => PromptBlockDataNullishDecisionsInputVariant2ItemRole.User,
                _ => null,
            };
        }
    }
}