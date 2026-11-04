
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIngestKeyRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIngestKeyRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIngestKeyRequest(
            global::System.Guid projectId,
            string name)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIngestKeyRequest" /> class.
        /// </summary>
        public CreateIngestKeyRequest()
        {
        }

    }
}