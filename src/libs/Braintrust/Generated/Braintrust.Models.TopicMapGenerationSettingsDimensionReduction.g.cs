
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicMapGenerationSettingsDimensionReduction
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Pca,
        /// <summary>
        /// 
        /// </summary>
        Umap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicMapGenerationSettingsDimensionReductionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapGenerationSettingsDimensionReduction value)
        {
            return value switch
            {
                TopicMapGenerationSettingsDimensionReduction.None => "none",
                TopicMapGenerationSettingsDimensionReduction.Pca => "pca",
                TopicMapGenerationSettingsDimensionReduction.Umap => "umap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapGenerationSettingsDimensionReduction? ToEnum(string value)
        {
            return value switch
            {
                "none" => TopicMapGenerationSettingsDimensionReduction.None,
                "pca" => TopicMapGenerationSettingsDimensionReduction.Pca,
                "umap" => TopicMapGenerationSettingsDimensionReduction.Umap,
                _ => null,
            };
        }
    }
}