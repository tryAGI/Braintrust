
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WindowedAutomationConfigWindowScheduleVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigWindowScheduleVariant2TypeJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type Type { get; set; }

        /// <summary>
        /// A standard five-field cron expression (minute hour day-of-month month day-of-week) controlling when the automation runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronExpression { get; set; }

        /// <summary>
        /// IANA timezone used to interpret the cron expression (defaults to UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigWindowScheduleVariant2" /> class.
        /// </summary>
        /// <param name="cronExpression">
        /// A standard five-field cron expression (minute hour day-of-month month day-of-week) controlling when the automation runs
        /// </param>
        /// <param name="type"></param>
        /// <param name="timezone">
        /// IANA timezone used to interpret the cron expression (defaults to UTC)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigWindowScheduleVariant2(
            string cronExpression,
            global::Braintrust.WindowedAutomationConfigWindowScheduleVariant2Type type,
            string? timezone)
        {
            this.Type = type;
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigWindowScheduleVariant2" /> class.
        /// </summary>
        public WindowedAutomationConfigWindowScheduleVariant2()
        {
        }

    }
}