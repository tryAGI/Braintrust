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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.EvalStatusPage> GetEvalStatusPageIdAsync(
            global::System.Guid evalStatusPageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}