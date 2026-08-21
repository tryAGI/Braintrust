
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicMapDataSourceFacetFunctionVariant2FunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicMapDataSourceFacetFunctionVariant2FunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapDataSourceFacetFunctionVariant2FunctionType value)
        {
            return value switch
            {
                TopicMapDataSourceFacetFunctionVariant2FunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapDataSourceFacetFunctionVariant2FunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => TopicMapDataSourceFacetFunctionVariant2FunctionType.Function,
                _ => null,
            };
        }
    }
}