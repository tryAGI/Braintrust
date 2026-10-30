
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetRestorePreviewResponse
    {
        /// <summary>
        /// Number of rows that would be restored to their value at the requested version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_to_restore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowsToRestore { get; set; }

        /// <summary>
        /// Number of rows created after the requested version that would be deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_to_delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowsToDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRestorePreviewResponse" /> class.
        /// </summary>
        /// <param name="rowsToRestore">
        /// Number of rows that would be restored to their value at the requested version
        /// </param>
        /// <param name="rowsToDelete">
        /// Number of rows created after the requested version that would be deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetRestorePreviewResponse(
            int rowsToRestore,
            int rowsToDelete)
        {
            this.RowsToRestore = rowsToRestore;
            this.RowsToDelete = rowsToDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRestorePreviewResponse" /> class.
        /// </summary>
        public DatasetRestorePreviewResponse()
        {
        }

    }
}