
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCustomColumn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.AclObjectType?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AllOf<global::Braintrust.AclObjectType?, object> ObjectType { get; set; }

        /// <summary>
        /// The ID of the scoping object. Use the project ID for project logs, experiment spans, and the experiments list. Use the dataset ID for dataset rows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ObjectId { get; set; }

        /// <summary>
        /// The child object type the custom column applies to, such as `experiment` or `project_log`. Use an empty string when the column applies directly to the scoping object, such as a dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtype")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AclObjectType?, global::Braintrust.CreateCustomColumnSubtype?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CreateCustomColumnSubtype?> Subtype { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.CustomColumnVariant?, object>))]
        public global::Braintrust.AllOf<global::Braintrust.CustomColumnVariant?, object>? Variant { get; set; }

        /// <summary>
        /// The name of the custom column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The expression used to extract the value for the custom column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomColumn" /> class.
        /// </summary>
        /// <param name="objectType"></param>
        /// <param name="objectId">
        /// The ID of the scoping object. Use the project ID for project logs, experiment spans, and the experiments list. Use the dataset ID for dataset rows
        /// </param>
        /// <param name="subtype">
        /// The child object type the custom column applies to, such as `experiment` or `project_log`. Use an empty string when the column applies directly to the scoping object, such as a dataset
        /// </param>
        /// <param name="name">
        /// The name of the custom column
        /// </param>
        /// <param name="expr">
        /// The expression used to extract the value for the custom column
        /// </param>
        /// <param name="variant"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCustomColumn(
            global::Braintrust.AllOf<global::Braintrust.AclObjectType?, object> objectType,
            global::System.Guid objectId,
            global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CreateCustomColumnSubtype?> subtype,
            string name,
            string expr,
            global::Braintrust.AllOf<global::Braintrust.CustomColumnVariant?, object>? variant)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Subtype = subtype;
            this.Variant = variant;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Expr = expr ?? throw new global::System.ArgumentNullException(nameof(expr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomColumn" /> class.
        /// </summary>
        public CreateCustomColumn()
        {
        }

    }
}