
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum CodeBundleLocationExperimentPositionClassifierType
    {
        /// <summary>
        ///
        /// </summary>
        Classifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationExperimentPositionClassifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationExperimentPositionClassifierType value)
        {
            return value switch
            {
                CodeBundleLocationExperimentPositionClassifierType.Classifier => "classifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationExperimentPositionClassifierType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => CodeBundleLocationExperimentPositionClassifierType.Classifier,
                _ => null,
            };
        }
    }
}