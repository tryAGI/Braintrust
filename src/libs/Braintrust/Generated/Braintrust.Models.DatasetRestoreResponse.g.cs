
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetRestoreResponse
    {
        /// <summary>
        /// Transaction id of the restore, or null if the restore made no changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xact_id")]
        public string? XactId { get; set; }

        /// <summary>
        /// Number of rows restored to their value at the requested version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_restored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowsRestored { get; set; }

        /// <summary>
        /// Number of rows created after the requested version that were deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowsDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRestoreResponse" /> class.
        /// </summary>
        /// <param name="rowsRestored">
        /// Number of rows restored to their value at the requested version
        /// </param>
        /// <param name="rowsDeleted">
        /// Number of rows created after the requested version that were deleted
        /// </param>
        /// <param name="xactId">
        /// Transaction id of the restore, or null if the restore made no changes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetRestoreResponse(
            int rowsRestored,
            int rowsDeleted,
            string? xactId)
        {
            this.XactId = xactId;
            this.RowsRestored = rowsRestored;
            this.RowsDeleted = rowsDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRestoreResponse" /> class.
        /// </summary>
        public DatasetRestoreResponse()
        {
        }

    }
}