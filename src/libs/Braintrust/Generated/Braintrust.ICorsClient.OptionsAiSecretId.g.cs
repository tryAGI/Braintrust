#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/ai_secret/{ai_secret_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="aiSecretId">
        /// AiSecret id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsAiSecretIdAsync(
            global::System.Guid aiSecretId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}