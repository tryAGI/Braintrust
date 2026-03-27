#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/role/{role_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="roleId">
        /// Role id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsRoleIdAsync(
            global::System.Guid roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}