#nullable enable

namespace Braintrust
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Create group<br/>
        /// Create a new group. If there is an existing group with the same name as the one specified in the request, will return the existing group unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Group> PostGroupAsync(

            global::Braintrust.CreateGroup request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create group<br/>
        /// Create a new group. If there is an existing group with the same name as the one specified in the request, will return the existing group unmodified
        /// </summary>
        /// <param name="name">
        /// Name of the group
        /// </param>
        /// <param name="description">
        /// Textual description of the group
        /// </param>
        /// <param name="memberUsers">
        /// Ids of users which belong to this group
        /// </param>
        /// <param name="memberGroups">
        /// Ids of the groups this group inherits from<br/>
        /// An inheriting group has all the users contained in its member groups, as well as all of their inherited users
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the group belongs in.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Group> PostGroupAsync(
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<global::System.Guid>? memberUsers = default,
            global::System.Collections.Generic.IList<global::System.Guid>? memberGroups = default,
            string? orgName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}