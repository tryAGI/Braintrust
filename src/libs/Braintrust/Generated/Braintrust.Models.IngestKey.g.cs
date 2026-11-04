
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IngestKey
    {
        /// <summary>
        /// Unique identifier for the ingest key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Date of ingest key creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the ingest key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the ingest key
        /// </param>
        /// <param name="name">
        /// Name of the ingest key
        /// </param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="previewName"></param>
        /// <param name="created">
        /// Date of ingest key creation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IngestKey(
            global::System.Guid id,
            string name,
            global::System.Guid orgId,
            global::System.Guid projectId,
            string previewName,
            global::System.DateTime? created)
        {
            this.Id = id;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.PreviewName = previewName ?? throw new global::System.ArgumentNullException(nameof(previewName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestKey" /> class.
        /// </summary>
        public IngestKey()
        {
        }

    }
}