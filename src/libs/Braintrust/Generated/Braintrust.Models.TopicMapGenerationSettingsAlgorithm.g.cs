
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicMapGenerationSettingsAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        Community,
        /// <summary>
        /// 
        /// </summary>
        Hdbscan,
        /// <summary>
        /// 
        /// </summary>
        Kmeans,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicMapGenerationSettingsAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapGenerationSettingsAlgorithm value)
        {
            return value switch
            {
                TopicMapGenerationSettingsAlgorithm.Community => "community",
                TopicMapGenerationSettingsAlgorithm.Hdbscan => "hdbscan",
                TopicMapGenerationSettingsAlgorithm.Kmeans => "kmeans",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapGenerationSettingsAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "community" => TopicMapGenerationSettingsAlgorithm.Community,
                "hdbscan" => TopicMapGenerationSettingsAlgorithm.Hdbscan,
                "kmeans" => TopicMapGenerationSettingsAlgorithm.Kmeans,
                _ => null,
            };
        }
    }
}