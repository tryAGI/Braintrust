#nullable enable

namespace Braintrust
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Preview dataset restore<br/>
        /// Preview restoring a dataset to an earlier version, such as a dataset snapshot. Returns how many rows a restore would change, without modifying the dataset. Fails if more than 20,000 rows changed since the requested version. Requires read permission on the dataset.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetRestorePreviewResponse> PostDatasetIdRestorePreviewAsync(
            global::System.Guid datasetId,

            global::Braintrust.DatasetRestoreRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview dataset restore<br/>
        /// Preview restoring a dataset to an earlier version, such as a dataset snapshot. Returns how many rows a restore would change, without modifying the dataset. Fails if more than 20,000 rows changed since the requested version. Requires read permission on the dataset.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.DatasetRestorePreviewResponse>> PostDatasetIdRestorePreviewAsResponseAsync(
            global::System.Guid datasetId,

            global::Braintrust.DatasetRestoreRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview dataset restore<br/>
        /// Preview restoring a dataset to an earlier version, such as a dataset snapshot. Returns how many rows a restore would change, without modifying the dataset. Fails if more than 20,000 rows changed since the requested version. Requires read permission on the dataset.
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
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetRestorePreviewResponse> PostDatasetIdRestorePreviewAsync(
            global::System.Guid datasetId,
            string version,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}