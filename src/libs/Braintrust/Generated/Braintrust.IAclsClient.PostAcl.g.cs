#nullable enable

namespace Braintrust
{
    public partial interface IAclsClient
    {
        /// <summary>
        /// Create ACL<br/>
        /// Create a new ACL. If there is an existing ACL with the same contents as the one specified in the request, will return the existing ACL unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Acl> PostAclAsync(

            global::Braintrust.AclItem request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create ACL<br/>
        /// Create a new ACL. If there is an existing ACL with the same contents as the one specified in the request, will return the existing ACL unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.Acl>> PostAclAsResponseAsync(

            global::Braintrust.AclItem request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create ACL<br/>
        /// Create a new ACL. If there is an existing ACL with the same contents as the one specified in the request, will return the existing ACL unmodified
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the ACL applies to
        /// </param>
        /// <param name="userId">
        /// Id of the user the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="groupId">
        /// Id of the group the ACL applies to. Exactly one of `user_id` and `group_id` will be provided
        /// </param>
        /// <param name="permission">
        /// Permission the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </param>
        /// <param name="restrictObjectType">
        /// When setting a permission directly, optionally restricts the permission grant to just the specified object type. Cannot be set alongside a `role_id`.
        /// </param>
        /// <param name="roleId">
        /// Id of the role the ACL grants. Exactly one of `permission` and `role_id` will be provided
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Acl> PostAclAsync(
            global::Braintrust.AclObjectType objectType,
            global::System.Guid objectId,
            global::System.Guid? userId = default,
            global::System.Guid? groupId = default,
            global::Braintrust.Permission? permission = default,
            global::Braintrust.AclObjectType? restrictObjectType = default,
            global::System.Guid? roleId = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}