
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Optional facet model override for topic automation
    /// </summary>
    public enum TopicAutomationFacetModel
    {
        /// <summary>
        /// 
        /// </summary>
        BrainFacet1,
        /// <summary>
        /// 
        /// </summary>
        BrainFacet2,
        /// <summary>
        /// 
        /// </summary>
        BrainFacetLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicAutomationFacetModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicAutomationFacetModel value)
        {
            return value switch
            {
                TopicAutomationFacetModel.BrainFacet1 => "brain-facet-1",
                TopicAutomationFacetModel.BrainFacet2 => "brain-facet-2",
                TopicAutomationFacetModel.BrainFacetLatest => "brain-facet-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicAutomationFacetModel? ToEnum(string value)
        {
            return value switch
            {
                "brain-facet-1" => TopicAutomationFacetModel.BrainFacet1,
                "brain-facet-2" => TopicAutomationFacetModel.BrainFacet2,
                "brain-facet-latest" => TopicAutomationFacetModel.BrainFacetLatest,
                _ => null,
            };
        }
    }
}