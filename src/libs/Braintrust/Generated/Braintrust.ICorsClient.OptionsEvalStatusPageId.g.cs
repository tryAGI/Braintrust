#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/eval_status_page/{eval_status_page_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="evalStatusPageId">
        /// EvalStatusPage id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsEvalStatusPageIdAsync(
            global::System.Guid evalStatusPageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}