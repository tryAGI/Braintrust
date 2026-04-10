#nullable enable

namespace Braintrust
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Feedback for project logs events<br/>
        /// Log feedback for a set of project logs events
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.FeedbackResponseSchema> PostProjectLogsIdFeedbackAsync(
            global::System.Guid projectId,

            global::Braintrust.FeedbackProjectLogsEventRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback for project logs events<br/>
        /// Log feedback for a set of project logs events
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="feedback">
        /// A list of project logs feedback items
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.FeedbackResponseSchema> PostProjectLogsIdFeedbackAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::Braintrust.FeedbackProjectLogsItem> feedback,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}