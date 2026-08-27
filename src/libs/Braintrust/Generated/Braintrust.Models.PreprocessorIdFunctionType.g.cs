
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PreprocessorIdFunctionType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreprocessorIdFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreprocessorIdFunctionType value)
        {
            return value switch
            {
                PreprocessorIdFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreprocessorIdFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PreprocessorIdFunctionType.Function,
                _ => null,
            };
        }
    }
}