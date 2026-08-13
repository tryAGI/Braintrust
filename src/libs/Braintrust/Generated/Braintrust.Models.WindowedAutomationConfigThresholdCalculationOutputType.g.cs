
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum WindowedAutomationConfigThresholdCalculationOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Scalar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigThresholdCalculationOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigThresholdCalculationOutputType value)
        {
            return value switch
            {
                WindowedAutomationConfigThresholdCalculationOutputType.Scalar => "scalar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigThresholdCalculationOutputType? ToEnum(string value)
        {
            return value switch
            {
                "scalar" => WindowedAutomationConfigThresholdCalculationOutputType.Scalar,
                _ => null,
            };
        }
    }
}