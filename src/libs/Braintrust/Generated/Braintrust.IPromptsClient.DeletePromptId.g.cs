#nullable enable

namespace Braintrust
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete prompt<br/>
        /// Delete a prompt object by its id
        /// </summary>
        /// <param name="promptId">
        /// Prompt id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Prompt> DeletePromptIdAsync(
            global::System.Guid promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}