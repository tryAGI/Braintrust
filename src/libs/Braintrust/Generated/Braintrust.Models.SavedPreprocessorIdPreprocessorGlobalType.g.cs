
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum SavedPreprocessorIdPreprocessorGlobalType
    {
        /// <summary>
        ///
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SavedPreprocessorIdPreprocessorGlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedPreprocessorIdPreprocessorGlobalType value)
        {
            return value switch
            {
                SavedPreprocessorIdPreprocessorGlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedPreprocessorIdPreprocessorGlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => SavedPreprocessorIdPreprocessorGlobalType.Global,
                _ => null,
            };
        }
    }
}