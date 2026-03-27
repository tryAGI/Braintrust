#nullable enable

namespace Braintrust
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Delete role<br/>
        /// Delete a role object by its id
        /// </summary>
        /// <param name="roleId">
        /// Role id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Role> DeleteRoleIdAsync(
            global::System.Guid roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}