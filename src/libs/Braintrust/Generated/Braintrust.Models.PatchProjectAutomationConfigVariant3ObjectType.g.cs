
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The source object type for the async query
    /// </summary>
    public enum PatchProjectAutomationConfigVariant3ObjectType
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
    public static class PatchProjectAutomationConfigVariant3ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant3ObjectType value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant3ObjectType.Dataset => "dataset",
                PatchProjectAutomationConfigVariant3ObjectType.Experiment => "experiment",
                PatchProjectAutomationConfigVariant3ObjectType.PlaygroundLogs => "playground_logs",
                PatchProjectAutomationConfigVariant3ObjectType.ProjectLogs => "project_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant3ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => PatchProjectAutomationConfigVariant3ObjectType.Dataset,
                "experiment" => PatchProjectAutomationConfigVariant3ObjectType.Experiment,
                "playground_logs" => PatchProjectAutomationConfigVariant3ObjectType.PlaygroundLogs,
                "project_logs" => PatchProjectAutomationConfigVariant3ObjectType.ProjectLogs,
                _ => null,
            };
        }
    }
}