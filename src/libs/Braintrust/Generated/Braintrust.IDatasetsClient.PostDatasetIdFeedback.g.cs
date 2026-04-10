#nullable enable

namespace Braintrust
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Feedback for dataset events<br/>
        /// Log feedback for a set of dataset events
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.FeedbackResponseSchema> PostDatasetIdFeedbackAsync(
            global::System.Guid datasetId,

            global::Braintrust.FeedbackDatasetEventRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback for dataset events<br/>
        /// Log feedback for a set of dataset events
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="feedback">
        /// A list of dataset feedback items
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.FeedbackResponseSchema> PostDatasetIdFeedbackAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::Braintrust.FeedbackDatasetItem> feedback,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}