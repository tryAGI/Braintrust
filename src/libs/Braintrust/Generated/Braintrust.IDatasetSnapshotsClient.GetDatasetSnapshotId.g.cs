#nullable enable

namespace Braintrust
{
    public partial interface IDatasetSnapshotsClient
    {
        /// <summary>
        /// Get dataset_snapshot<br/>
        /// Get a dataset_snapshot object by its id
        /// </summary>
        /// <param name="datasetSnapshotId">
        /// DatasetSnapshot id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetSnapshot> GetDatasetSnapshotIdAsync(
            global::System.Guid datasetSnapshotId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}