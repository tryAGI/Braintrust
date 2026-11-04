
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum GetCustomColumnSubtype2
    {
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCustomColumnSubtype2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCustomColumnSubtype2 value)
        {
            return value switch
            {
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCustomColumnSubtype2? ToEnum(string value)
        {
            return value switch
            {
                _ => null,
            };
        }
    }
}