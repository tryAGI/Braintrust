
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum TopicDigestAutomationConfigActionType
    {
        /// <summary>
        ///
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicDigestAutomationConfigActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicDigestAutomationConfigActionType value)
        {
            return value switch
            {
                TopicDigestAutomationConfigActionType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicDigestAutomationConfigActionType? ToEnum(string value)
        {
            return value switch
            {
                "slack" => TopicDigestAutomationConfigActionType.Slack,
                _ => null,
            };
        }
    }
}