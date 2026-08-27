
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FacetPreprocessorIdFunctionType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FacetPreprocessorIdFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FacetPreprocessorIdFunctionType value)
        {
            return value switch
            {
                FacetPreprocessorIdFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FacetPreprocessorIdFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FacetPreprocessorIdFunctionType.Function,
                _ => null,
            };
        }
    }
}