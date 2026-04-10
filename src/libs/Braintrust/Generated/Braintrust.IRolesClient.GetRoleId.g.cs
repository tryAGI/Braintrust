#nullable enable

namespace Braintrust
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Get role<br/>
        /// Get a role object by its id
        /// </summary>
        /// <param name="roleId">
        /// Role id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Role> GetRoleIdAsync(
            global::System.Guid roleId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}