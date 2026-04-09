#nullable enable

namespace Braintrust
{
    public partial interface IDatasetSnapshotsClient
    {
        /// <summary>
        /// Partially update dataset_snapshot<br/>
        /// Partially update a dataset_snapshot object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="datasetSnapshotId">
        /// DatasetSnapshot id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetSnapshot> PatchDatasetSnapshotIdAsync(
            global::System.Guid datasetSnapshotId,

            global::Braintrust.PatchDatasetSnapshot request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update dataset_snapshot<br/>
        /// Partially update a dataset_snapshot object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="datasetSnapshotId">
        /// DatasetSnapshot id
        /// </param>
        /// <param name="name">
        /// Name of the dataset snapshot
        /// </param>
        /// <param name="description">
        /// Textual description of the dataset snapshot
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetSnapshot> PatchDatasetSnapshotIdAsync(
            global::System.Guid datasetSnapshotId,
            string? name = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}