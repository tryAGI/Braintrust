
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigLoopTargetId
    {
        /// <summary>
        ///
        /// </summary>
        Overview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigLoopTargetIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigLoopTargetId value)
        {
            return value switch
            {
                WindowedAutomationConfigLoopTargetId.Overview => "overview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigLoopTargetId? ToEnum(string value)
        {
            return value switch
            {
                "overview" => WindowedAutomationConfigLoopTargetId.Overview,
                _ => null,
            };
        }
    }
}