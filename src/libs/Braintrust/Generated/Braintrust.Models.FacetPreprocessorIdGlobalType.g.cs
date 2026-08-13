
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum FacetPreprocessorIdGlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FacetPreprocessorIdGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FacetPreprocessorIdGlobalType value)
        {
            return value switch
            {
                FacetPreprocessorIdGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FacetPreprocessorIdGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => FacetPreprocessorIdGlobalType.Global,
                _ => null,
            };
        }
    }
}