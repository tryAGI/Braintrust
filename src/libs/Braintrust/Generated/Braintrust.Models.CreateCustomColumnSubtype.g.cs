
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCustomColumnSubtype
    {
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCustomColumnSubtypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomColumnSubtype value)
        {
            return value switch
            {
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomColumnSubtype? ToEnum(string value)
        {
            return value switch
            {
                _ => null,
            };
        }
    }
}