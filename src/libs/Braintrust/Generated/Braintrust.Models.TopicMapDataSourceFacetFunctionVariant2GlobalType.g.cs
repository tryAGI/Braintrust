
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum TopicMapDataSourceFacetFunctionVariant2GlobalType
    {
        /// <summary>
        ///
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicMapDataSourceFacetFunctionVariant2GlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapDataSourceFacetFunctionVariant2GlobalType value)
        {
            return value switch
            {
                TopicMapDataSourceFacetFunctionVariant2GlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapDataSourceFacetFunctionVariant2GlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => TopicMapDataSourceFacetFunctionVariant2GlobalType.Global,
                _ => null,
            };
        }
    }
}