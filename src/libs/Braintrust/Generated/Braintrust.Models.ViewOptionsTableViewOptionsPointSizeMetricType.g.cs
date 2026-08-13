
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum ViewOptionsTableViewOptionsPointSizeMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Metric,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsTableViewOptionsPointSizeMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsTableViewOptionsPointSizeMetricType value)
        {
            return value switch
            {
                ViewOptionsTableViewOptionsPointSizeMetricType.Metadata => "metadata",
                ViewOptionsTableViewOptionsPointSizeMetricType.Metric => "metric",
                ViewOptionsTableViewOptionsPointSizeMetricType.None => "none",
                ViewOptionsTableViewOptionsPointSizeMetricType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsTableViewOptionsPointSizeMetricType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => ViewOptionsTableViewOptionsPointSizeMetricType.Metadata,
                "metric" => ViewOptionsTableViewOptionsPointSizeMetricType.Metric,
                "none" => ViewOptionsTableViewOptionsPointSizeMetricType.None,
                "score" => ViewOptionsTableViewOptionsPointSizeMetricType.Score,
                _ => null,
            };
        }
    }
}