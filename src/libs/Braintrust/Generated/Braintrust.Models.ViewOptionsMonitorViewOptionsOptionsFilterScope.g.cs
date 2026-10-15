
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ViewOptionsMonitorViewOptionsOptionsFilterScope
    {
        /// <summary>
        ///
        /// </summary>
        Span,
        /// <summary>
        ///
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsMonitorViewOptionsOptionsFilterScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsMonitorViewOptionsOptionsFilterScope value)
        {
            return value switch
            {
                ViewOptionsMonitorViewOptionsOptionsFilterScope.Span => "span",
                ViewOptionsMonitorViewOptionsOptionsFilterScope.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsMonitorViewOptionsOptionsFilterScope? ToEnum(string value)
        {
            return value switch
            {
                "span" => ViewOptionsMonitorViewOptionsOptionsFilterScope.Span,
                "trace" => ViewOptionsMonitorViewOptionsOptionsFilterScope.Trace,
                _ => null,
            };
        }
    }
}