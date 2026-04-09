
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetSnapshot
    {
        /// <summary>
        /// Unique identifier for the dataset snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique identifier for the dataset that this snapshot belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// Name of the dataset snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Transaction id of the brainstore version at the time of the snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XactId { get; set; }

        /// <summary>
        /// Date of dataset snapshot creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSnapshot" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the dataset snapshot
        /// </param>
        /// <param name="datasetId">
        /// Unique identifier for the dataset that this snapshot belongs to
        /// </param>
        /// <param name="name">
        /// Name of the dataset snapshot
        /// </param>
        /// <param name="xactId">
        /// Transaction id of the brainstore version at the time of the snapshot
        /// </param>
        /// <param name="description"></param>
        /// <param name="created">
        /// Date of dataset snapshot creation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSnapshot(
            global::System.Guid id,
            global::System.Guid datasetId,
            string name,
            string xactId,
            string? description,
            global::System.DateTime? created)
        {
            this.Id = id;
            this.DatasetId = datasetId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.XactId = xactId ?? throw new global::System.ArgumentNullException(nameof(xactId));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSnapshot" /> class.
        /// </summary>
        public DatasetSnapshot()
        {
        }
    }
}