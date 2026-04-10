#nullable enable

namespace Braintrust
{
    public partial interface IAclsClient
    {
        /// <summary>
        /// Get acl<br/>
        /// Get an acl object by its id
        /// </summary>
        /// <param name="aclId">
        /// Acl id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Acl> GetAclIdAsync(
            global::System.Guid aclId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}