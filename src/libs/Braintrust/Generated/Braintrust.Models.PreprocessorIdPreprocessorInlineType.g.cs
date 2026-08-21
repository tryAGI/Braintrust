
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreprocessorIdPreprocessorInlineType
    {
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreprocessorIdPreprocessorInlineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreprocessorIdPreprocessorInlineType value)
        {
            return value switch
            {
                PreprocessorIdPreprocessorInlineType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreprocessorIdPreprocessorInlineType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => PreprocessorIdPreprocessorInlineType.Inline,
                _ => null,
            };
        }
    }
}