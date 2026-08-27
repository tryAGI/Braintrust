
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The source object type for the async query
    /// </summary>
    public enum ProjectAutomationConfigVariant3ObjectType
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
        PlaygroundLogs,
        /// <summary>
        ///
        /// </summary>
        ProjectLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant3ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant3ObjectType value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant3ObjectType.Dataset => "dataset",
                ProjectAutomationConfigVariant3ObjectType.Experiment => "experiment",
                ProjectAutomationConfigVariant3ObjectType.PlaygroundLogs => "playground_logs",
                ProjectAutomationConfigVariant3ObjectType.ProjectLogs => "project_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant3ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ProjectAutomationConfigVariant3ObjectType.Dataset,
                "experiment" => ProjectAutomationConfigVariant3ObjectType.Experiment,
                "playground_logs" => ProjectAutomationConfigVariant3ObjectType.PlaygroundLogs,
                "project_logs" => ProjectAutomationConfigVariant3ObjectType.ProjectLogs,
                _ => null,
            };
        }
    }
}