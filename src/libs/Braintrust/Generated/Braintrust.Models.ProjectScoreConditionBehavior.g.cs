
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Default Value: hidden
    /// </summary>
    public enum ProjectScoreConditionBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Hidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectScoreConditionBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectScoreConditionBehavior value)
        {
            return value switch
            {
                ProjectScoreConditionBehavior.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectScoreConditionBehavior? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => ProjectScoreConditionBehavior.Hidden,
                _ => null,
            };
        }
    }
}