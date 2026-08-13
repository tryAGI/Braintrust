
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum FacetPreprocessorIdPreprocessorInlineType
    {
        /// <summary>
        /// 
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FacetPreprocessorIdPreprocessorInlineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FacetPreprocessorIdPreprocessorInlineType value)
        {
            return value switch
            {
                FacetPreprocessorIdPreprocessorInlineType.Inline => "inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FacetPreprocessorIdPreprocessorInlineType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => FacetPreprocessorIdPreprocessorInlineType.Inline,
                _ => null,
            };
        }
    }
}