
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreprocessorSavedFunctionIdFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreprocessorSavedFunctionIdFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreprocessorSavedFunctionIdFunctionType value)
        {
            return value switch
            {
                PreprocessorSavedFunctionIdFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreprocessorSavedFunctionIdFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PreprocessorSavedFunctionIdFunctionType.Function,
                _ => null,
            };
        }
    }
}