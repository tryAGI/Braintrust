
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectScoreConfigObjectType
    {
        /// <summary>
        ///
        /// </summary>
        Dataset,
        /// <summary>
        ///
        /// </summary>
        Experiment,
        /// <summary>
        ///
        /// </summary>
        ProjectLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectScoreConfigObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectScoreConfigObjectType value)
        {
            return value switch
            {
                ProjectScoreConfigObjectType.Dataset => "dataset",
                ProjectScoreConfigObjectType.Experiment => "experiment",
                ProjectScoreConfigObjectType.ProjectLogs => "project_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectScoreConfigObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ProjectScoreConfigObjectType.Dataset,
                "experiment" => ProjectScoreConfigObjectType.Experiment,
                "project_logs" => ProjectScoreConfigObjectType.ProjectLogs,
                _ => null,
            };
        }
    }
}