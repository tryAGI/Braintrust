
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// How reconciliation carries the previous map forward: "evolve" re-routes new samples into the previous topics before naming; "names_only" keeps the fresh clustering and carries only topic ids/names. Defaults to "names_only" when omitted.
    /// </summary>
    public enum TopicMapDataReconcileMode
    {
        /// <summary>
        /// "evolve" re-routes new samples into the previous topics before naming; "names_only" keeps the fresh clustering and carries only topic ids/names. Defaults to "names_only" when omitted.
        /// </summary>
        Evolve,
        /// <summary>
        /// "evolve" re-routes new samples into the previous topics before naming; "names_only" keeps the fresh clustering and carries only topic ids/names. Defaults to "names_only" when omitted.
        /// </summary>
        NamesOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicMapDataReconcileModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapDataReconcileMode value)
        {
            return value switch
            {
                TopicMapDataReconcileMode.Evolve => "evolve",
                TopicMapDataReconcileMode.NamesOnly => "names_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapDataReconcileMode? ToEnum(string value)
        {
            return value switch
            {
                "evolve" => TopicMapDataReconcileMode.Evolve,
                "names_only" => TopicMapDataReconcileMode.NamesOnly,
                _ => null,
            };
        }
    }
}