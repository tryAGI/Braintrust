
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum TopicDigestAutomationConfigEventType
    {
        /// <summary>
        ///
        /// </summary>
        TopicDigest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicDigestAutomationConfigEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicDigestAutomationConfigEventType value)
        {
            return value switch
            {
                TopicDigestAutomationConfigEventType.TopicDigest => "topic_digest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicDigestAutomationConfigEventType? ToEnum(string value)
        {
            return value switch
            {
                "topic_digest" => TopicDigestAutomationConfigEventType.TopicDigest,
                _ => null,
            };
        }
    }
}