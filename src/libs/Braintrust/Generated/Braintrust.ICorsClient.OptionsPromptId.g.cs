#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/prompt/{prompt_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="promptId">
        /// Prompt id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsPromptIdAsync(
            global::System.Guid promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}