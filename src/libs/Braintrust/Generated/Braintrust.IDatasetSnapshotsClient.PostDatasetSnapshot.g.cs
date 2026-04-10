#nullable enable

namespace Braintrust
{
    public partial interface IDatasetSnapshotsClient
    {
        /// <summary>
        /// Create dataset_snapshot<br/>
        /// Create a new dataset_snapshot. If there is an existing dataset_snapshot with the same name as the one specified in the request, will return the existing dataset_snapshot unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetSnapshot> PostDatasetSnapshotAsync(

            global::Braintrust.CreateDatasetSnapshot request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset_snapshot<br/>
        /// Create a new dataset_snapshot. If there is an existing dataset_snapshot with the same name as the one specified in the request, will return the existing dataset_snapshot unmodified
        /// </summary>
        /// <param name="datasetId">
        /// Unique identifier for the dataset that this snapshot belongs to
        /// </param>
        /// <param name="name">
        /// Name of the dataset snapshot
        /// </param>
        /// <param name="description">
        /// Textual description of the dataset snapshot
        /// </param>
        /// <param name="xactId">
        /// Transaction id of the brainstore version at the time of the snapshot
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.DatasetSnapshot> PostDatasetSnapshotAsync(
            global::System.Guid datasetId,
            string name,
            string xactId,
            string? description = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}