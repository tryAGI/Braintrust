
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of global function. Defaults to 'preprocessor'.<br/>
    /// Default Value: preprocessor
    /// </summary>
    public enum SavedPreprocessorIdPreprocessorGlobalFunctionType
    {
        /// <summary>
        ///
        /// </summary>
        Preprocessor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SavedPreprocessorIdPreprocessorGlobalFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedPreprocessorIdPreprocessorGlobalFunctionType value)
        {
            return value switch
            {
                SavedPreprocessorIdPreprocessorGlobalFunctionType.Preprocessor => "preprocessor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedPreprocessorIdPreprocessorGlobalFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "preprocessor" => SavedPreprocessorIdPreprocessorGlobalFunctionType.Preprocessor,
                _ => null,
            };
        }
    }
}