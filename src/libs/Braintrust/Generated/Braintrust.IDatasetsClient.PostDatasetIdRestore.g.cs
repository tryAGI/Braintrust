#nullable enable

namespace Braintrust
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Restore dataset<br/>
        /// Restore a dataset to an earlier version, such as a dataset snapshot. Rows changed since that version are reverted, and rows created since then are deleted. The restore is recorded as a new transaction, so dataset history is preserved. Fails if more than 20,000 rows changed since the requested version. Requires update permission on the dataset.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetRestoreResponse> PostDatasetIdRestoreAsync(
            global::System.Guid datasetId,

            global::Braintrust.DatasetRestoreRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore dataset<br/>
        /// Restore a dataset to an earlier version, such as a dataset snapshot. Rows changed since that version are reverted, and rows created since then are deleted. The restore is recorded as a new transaction, so dataset history is preserved. Fails if more than 20,000 rows changed since the requested version. Requires update permission on the dataset.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.DatasetRestoreResponse>> PostDatasetIdRestoreAsResponseAsync(
            global::System.Guid datasetId,

            global::Braintrust.DatasetRestoreRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore dataset<br/>
        /// Restore a dataset to an earlier version, such as a dataset snapshot. Rows changed since that version are reverted, and rows created since then are deleted. The restore is recorded as a new transaction, so dataset history is preserved. Fails if more than 20,000 rows changed since the requested version. Requires update permission on the dataset.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="version">
        /// The dataset version to restore to, such as the `xact_id` of a dataset snapshot
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetRestoreResponse> PostDatasetIdRestoreAsync(
            global::System.Guid datasetId,
            string version,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}