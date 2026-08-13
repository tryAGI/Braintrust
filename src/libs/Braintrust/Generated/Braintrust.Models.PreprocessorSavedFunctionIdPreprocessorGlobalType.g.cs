
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreprocessorSavedFunctionIdPreprocessorGlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreprocessorSavedFunctionIdPreprocessorGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreprocessorSavedFunctionIdPreprocessorGlobalType value)
        {
            return value switch
            {
                PreprocessorSavedFunctionIdPreprocessorGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreprocessorSavedFunctionIdPreprocessorGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => PreprocessorSavedFunctionIdPreprocessorGlobalType.Global,
                _ => null,
            };
        }
    }
}