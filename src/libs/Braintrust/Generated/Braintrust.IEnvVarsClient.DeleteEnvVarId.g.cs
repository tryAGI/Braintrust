#nullable enable

namespace Braintrust
{
    public partial interface IEnvVarsClient
    {
        /// <summary>
        /// Delete env_var<br/>
        /// Delete an env_var object by its id
        /// </summary>
        /// <param name="envVarId">
        /// EnvVar id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.EnvVar> DeleteEnvVarIdAsync(
            global::System.Guid envVarId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}