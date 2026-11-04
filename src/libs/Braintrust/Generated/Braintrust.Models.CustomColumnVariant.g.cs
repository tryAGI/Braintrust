
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The table variant that the custom column applies to
    /// </summary>
    public enum CustomColumnVariant
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
        ExperimentList,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        ProjectLog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomColumnVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomColumnVariant value)
        {
            return value switch
            {
                CustomColumnVariant.Dataset => "dataset",
                CustomColumnVariant.Experiment => "experiment",
                CustomColumnVariant.ExperimentList => "experiment_list",
                CustomColumnVariant.Project => "project",
                CustomColumnVariant.ProjectLog => "project_log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomColumnVariant? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => CustomColumnVariant.Dataset,
                "experiment" => CustomColumnVariant.Experiment,
                "experiment_list" => CustomColumnVariant.ExperimentList,
                "project" => CustomColumnVariant.Project,
                "project_log" => CustomColumnVariant.ProjectLog,
                _ => null,
            };
        }
    }
}