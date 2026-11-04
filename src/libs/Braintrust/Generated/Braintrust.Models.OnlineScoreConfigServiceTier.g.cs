
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Service tier for online scoring. If omitted, prompt-level service tiers are preserved.
    /// </summary>
    public enum OnlineScoreConfigServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnlineScoreConfigServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnlineScoreConfigServiceTier value)
        {
            return value switch
            {
                OnlineScoreConfigServiceTier.Flex => "flex",
                OnlineScoreConfigServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnlineScoreConfigServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "flex" => OnlineScoreConfigServiceTier.Flex,
                "standard" => OnlineScoreConfigServiceTier.Standard,
                _ => null,
            };
        }
    }
}