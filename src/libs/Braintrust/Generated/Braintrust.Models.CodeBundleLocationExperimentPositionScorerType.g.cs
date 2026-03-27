
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeBundleLocationExperimentPositionScorerType
    {
        /// <summary>
        /// 
        /// </summary>
        Scorer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationExperimentPositionScorerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationExperimentPositionScorerType value)
        {
            return value switch
            {
                CodeBundleLocationExperimentPositionScorerType.Scorer => "scorer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationExperimentPositionScorerType? ToEnum(string value)
        {
            return value switch
            {
                "scorer" => CodeBundleLocationExperimentPositionScorerType.Scorer,
                _ => null,
            };
        }
    }
}