
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum WindowedAutomationConfigEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Windowed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigEventType value)
        {
            return value switch
            {
                WindowedAutomationConfigEventType.Windowed => "windowed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigEventType? ToEnum(string value)
        {
            return value switch
            {
                "windowed" => WindowedAutomationConfigEventType.Windowed,
                _ => null,
            };
        }
    }
}