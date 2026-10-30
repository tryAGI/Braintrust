#nullable enable

namespace Braintrust
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Summarize dataset<br/>
        /// Return the dataset and project names and URLs. Set `summarize_data=true` to include the total number of records in the dataset; otherwise, only metadata is returned.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="summarizeData">
        /// Whether to summarize the data. If false (or omitted), only the metadata will be returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SummarizeDatasetResponse> GetDatasetIdSummarizeAsync(
            global::System.Guid datasetId,
            bool? summarizeData = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize dataset<br/>
        /// Return the dataset and project names and URLs. Set `summarize_data=true` to include the total number of records in the dataset; otherwise, only metadata is returned.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="summarizeData">
        /// Whether to summarize the data. If false (or omitted), only the metadata will be returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.SummarizeDatasetResponse>> GetDatasetIdSummarizeAsResponseAsync(
            global::System.Guid datasetId,
            bool? summarizeData = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}