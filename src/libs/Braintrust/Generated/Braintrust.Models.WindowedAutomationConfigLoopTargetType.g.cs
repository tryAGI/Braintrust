
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigLoopTargetType
    {
        /// <summary>
        ///
        /// </summary>
        Dashboard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigLoopTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigLoopTargetType value)
        {
            return value switch
            {
                WindowedAutomationConfigLoopTargetType.Dashboard => "dashboard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigLoopTargetType? ToEnum(string value)
        {
            return value switch
            {
                "dashboard" => WindowedAutomationConfigLoopTargetType.Dashboard,
                _ => null,
            };
        }
    }
}