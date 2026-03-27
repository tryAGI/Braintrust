#nullable enable

namespace Braintrust
{
    public partial interface IAiSecretsClient
    {
        /// <summary>
        /// Delete ai_secret<br/>
        /// Delete an ai_secret object by its id
        /// </summary>
        /// <param name="aiSecretId">
        /// AiSecret id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AISecret> DeleteAiSecretIdAsync(
            global::System.Guid aiSecretId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}