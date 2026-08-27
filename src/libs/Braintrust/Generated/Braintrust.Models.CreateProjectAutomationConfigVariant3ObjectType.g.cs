
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The source object type for the async query
    /// </summary>
    public enum CreateProjectAutomationConfigVariant3ObjectType
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
    public static class CreateProjectAutomationConfigVariant3ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant3ObjectType value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant3ObjectType.Dataset => "dataset",
                CreateProjectAutomationConfigVariant3ObjectType.Experiment => "experiment",
                CreateProjectAutomationConfigVariant3ObjectType.PlaygroundLogs => "playground_logs",
                CreateProjectAutomationConfigVariant3ObjectType.ProjectLogs => "project_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant3ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => CreateProjectAutomationConfigVariant3ObjectType.Dataset,
                "experiment" => CreateProjectAutomationConfigVariant3ObjectType.Experiment,
                "playground_logs" => CreateProjectAutomationConfigVariant3ObjectType.PlaygroundLogs,
                "project_logs" => CreateProjectAutomationConfigVariant3ObjectType.ProjectLogs,
                _ => null,
            };
        }
    }
}