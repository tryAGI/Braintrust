#nullable enable

namespace Braintrust
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user<br/>
        /// Get a user object by its id
        /// </summary>
        /// <param name="userId">
        /// User id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.User> GetUserIdAsync(
            global::System.Guid userId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}