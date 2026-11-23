
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum SavedPreprocessorIdFunctionType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SavedPreprocessorIdFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedPreprocessorIdFunctionType value)
        {
            return value switch
            {
                SavedPreprocessorIdFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedPreprocessorIdFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => SavedPreprocessorIdFunctionType.Function,
                _ => null,
            };
        }
    }
}