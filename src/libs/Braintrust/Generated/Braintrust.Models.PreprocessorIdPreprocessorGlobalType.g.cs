
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreprocessorIdPreprocessorGlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreprocessorIdPreprocessorGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreprocessorIdPreprocessorGlobalType value)
        {
            return value switch
            {
                PreprocessorIdPreprocessorGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreprocessorIdPreprocessorGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => PreprocessorIdPreprocessorGlobalType.Global,
                _ => null,
            };
        }
    }
}