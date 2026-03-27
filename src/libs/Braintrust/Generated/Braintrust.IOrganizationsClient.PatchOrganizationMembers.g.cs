#nullable enable

namespace Braintrust
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Modify organization membership<br/>
        /// Modify organization membership
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.PatchOrganizationMembersOutput> PatchOrganizationMembersAsync(

            global::Braintrust.PatchOrganizationMembers request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify organization membership<br/>
        /// Modify organization membership
        /// </summary>
        /// <param name="inviteUsers">
        /// Users to invite to the organization
        /// </param>
        /// <param name="removeUsers">
        /// Users to remove from the organization
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the name of the organization.
        /// </param>
        /// <param name="orgId">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the id of the organization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.PatchOrganizationMembersOutput> PatchOrganizationMembersAsync(
            global::Braintrust.PatchOrganizationMembersInviteUsers? inviteUsers = default,
            global::Braintrust.PatchOrganizationMembersRemoveUsers? removeUsers = default,
            string? orgName = default,
            string? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}