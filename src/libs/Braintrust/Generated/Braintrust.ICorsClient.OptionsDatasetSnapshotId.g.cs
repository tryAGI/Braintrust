#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/dataset_snapshot/{dataset_snapshot_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="datasetSnapshotId">
        /// DatasetSnapshot id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsDatasetSnapshotIdAsync(
            global::System.Guid datasetSnapshotId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}