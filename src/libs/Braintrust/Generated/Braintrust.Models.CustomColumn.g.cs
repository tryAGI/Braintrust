
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomColumn
    {
        /// <summary>
        /// Unique identifier for the custom columns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AclObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AclObjectType ObjectType { get; set; }

        /// <summary>
        /// The id of the object the custom column is scoped for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ObjectId { get; set; }

        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtype")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.AclObjectType?, global::Braintrust.CustomColumnSubtype?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CustomColumnSubtype?> Subtype { get; set; }

        /// <summary>
        /// The table variant that the custom column applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CustomColumnVariantJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.CustomColumnVariant Variant { get; set; }

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
        /// Date of custom columns creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColumn" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the custom columns
        /// </param>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the custom column is scoped for
        /// </param>
        /// <param name="subtype">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="variant">
        /// The table variant that the custom column applies to
        /// </param>
        /// <param name="name">
        /// The name of the custom column
        /// </param>
        /// <param name="expr">
        /// The expression used to extract the value for the custom column
        /// </param>
        /// <param name="created">
        /// Date of custom columns creation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomColumn(
            global::System.Guid id,
            global::Braintrust.AclObjectType objectType,
            global::System.Guid objectId,
            global::Braintrust.AnyOf<global::Braintrust.AclObjectType?, global::Braintrust.CustomColumnSubtype?> subtype,
            global::Braintrust.CustomColumnVariant variant,
            string name,
            string expr,
            global::System.DateTime? created)
        {
            this.Id = id;
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Subtype = subtype;
            this.Variant = variant;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Expr = expr ?? throw new global::System.ArgumentNullException(nameof(expr));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColumn" /> class.
        /// </summary>
        public CustomColumn()
        {
        }

    }
}