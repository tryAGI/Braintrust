
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The product surface that created and manages the automation
    /// </summary>
    public enum WindowedAutomationConfigProductOrigin
    {
        /// <summary>
        ///
        /// </summary>
        Patterns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigProductOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigProductOrigin value)
        {
            return value switch
            {
                WindowedAutomationConfigProductOrigin.Patterns => "patterns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigProductOrigin? ToEnum(string value)
        {
            return value switch
            {
                "patterns" => WindowedAutomationConfigProductOrigin.Patterns,
                _ => null,
            };
        }
    }
}