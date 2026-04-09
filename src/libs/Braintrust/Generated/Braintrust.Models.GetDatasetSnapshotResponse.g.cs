
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetSnapshotResponse
    {
        /// <summary>
        /// A list of dataset_snapshot objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.DatasetSnapshot> Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetSnapshotResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// A list of dataset_snapshot objects
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetSnapshotResponse(
            global::System.Collections.Generic.IList<global::Braintrust.DatasetSnapshot> objects)
        {
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetSnapshotResponse" /> class.
        /// </summary>
        public GetDatasetSnapshotResponse()
        {
        }
    }
}