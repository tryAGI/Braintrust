
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptBlockDataDecisionsInputVariant2ItemRole
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
    public static class PromptBlockDataDecisionsInputVariant2ItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockDataDecisionsInputVariant2ItemRole value)
        {
            return value switch
            {
                PromptBlockDataDecisionsInputVariant2ItemRole.Assistant => "assistant",
                PromptBlockDataDecisionsInputVariant2ItemRole.Developer => "developer",
                PromptBlockDataDecisionsInputVariant2ItemRole.System => "system",
                PromptBlockDataDecisionsInputVariant2ItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockDataDecisionsInputVariant2ItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => PromptBlockDataDecisionsInputVariant2ItemRole.Assistant,
                "developer" => PromptBlockDataDecisionsInputVariant2ItemRole.Developer,
                "system" => PromptBlockDataDecisionsInputVariant2ItemRole.System,
                "user" => PromptBlockDataDecisionsInputVariant2ItemRole.User,
                _ => null,
            };
        }
    }
}