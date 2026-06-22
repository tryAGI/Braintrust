
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum PatchProjectAutomationConfigVariant5ActionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant5ActionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant5ActionVariant1Type value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant5ActionVariant1Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant5ActionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => PatchProjectAutomationConfigVariant5ActionVariant1Type.Webhook,
                _ => null,
            };
        }
    }
}