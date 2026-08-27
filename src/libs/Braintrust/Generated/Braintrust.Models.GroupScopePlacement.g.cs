
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Which trace or traces to write grouped scorer results to
    /// </summary>
    public enum GroupScopePlacement
    {
        /// <summary>
        ///
        /// </summary>
        Each,
        /// <summary>
        ///
        /// </summary>
        First,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupScopePlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupScopePlacement value)
        {
            return value switch
            {
                GroupScopePlacement.Each => "each",
                GroupScopePlacement.First => "first",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupScopePlacement? ToEnum(string value)
        {
            return value switch
            {
                "each" => GroupScopePlacement.Each,
                "first" => GroupScopePlacement.First,
                _ => null,
            };
        }
    }
}