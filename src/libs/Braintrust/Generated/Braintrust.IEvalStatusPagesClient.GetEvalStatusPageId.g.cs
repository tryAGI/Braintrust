#nullable enable

namespace Braintrust
{
    public partial interface IEvalStatusPagesClient
    {
        /// <summary>
        /// Get eval_status_page<br/>
        /// Get a eval_status_page object by its id
        /// </summary>
        /// <param name="evalStatusPageId">
        /// EvalStatusPage id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.EvalStatusPage> GetEvalStatusPageIdAsync(
            global::System.Guid evalStatusPageId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}