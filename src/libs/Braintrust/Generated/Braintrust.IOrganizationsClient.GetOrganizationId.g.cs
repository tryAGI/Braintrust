#nullable enable

namespace Braintrust
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get organization<br/>
        /// Get an organization object by its id
        /// </summary>
        /// <param name="organizationId">
        /// Organization id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Organization> GetOrganizationIdAsync(
            global::System.Guid organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}