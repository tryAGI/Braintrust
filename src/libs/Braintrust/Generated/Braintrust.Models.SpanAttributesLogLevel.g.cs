
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Severity level of a log
    /// </summary>
    public enum SpanAttributesLogLevel
    {
        /// <summary>
        ///
        /// </summary>
        Debug,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Fatal,
        /// <summary>
        ///
        /// </summary>
        Info,
        /// <summary>
        ///
        /// </summary>
        Trace,
        /// <summary>
        ///
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanAttributesLogLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanAttributesLogLevel value)
        {
            return value switch
            {
                SpanAttributesLogLevel.Debug => "debug",
                SpanAttributesLogLevel.Error => "error",
                SpanAttributesLogLevel.Fatal => "fatal",
                SpanAttributesLogLevel.Info => "info",
                SpanAttributesLogLevel.Trace => "trace",
                SpanAttributesLogLevel.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanAttributesLogLevel? ToEnum(string value)
        {
            return value switch
            {
                "debug" => SpanAttributesLogLevel.Debug,
                "error" => SpanAttributesLogLevel.Error,
                "fatal" => SpanAttributesLogLevel.Fatal,
                "info" => SpanAttributesLogLevel.Info,
                "trace" => SpanAttributesLogLevel.Trace,
                "warn" => SpanAttributesLogLevel.Warn,
                _ => null,
            };
        }
    }
}