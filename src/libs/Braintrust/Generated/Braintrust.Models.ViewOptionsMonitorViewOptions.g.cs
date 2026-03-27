
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOptionsMonitorViewOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter))]
        public global::Braintrust.ViewOptionsMonitorViewOptionsViewType ViewType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.ViewOptionsMonitorViewOptionsOptions Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freezeColumns")]
        public bool? FreezeColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsMonitorViewOptions" /> class.
        /// </summary>
        /// <param name="viewType"></param>
        /// <param name="options"></param>
        /// <param name="freezeColumns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewOptionsMonitorViewOptions(
            global::Braintrust.ViewOptionsMonitorViewOptionsOptions options,
            global::Braintrust.ViewOptionsMonitorViewOptionsViewType viewType,
            bool? freezeColumns)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.ViewType = viewType;
            this.FreezeColumns = freezeColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsMonitorViewOptions" /> class.
        /// </summary>
        public ViewOptionsMonitorViewOptions()
        {
        }
    }
}