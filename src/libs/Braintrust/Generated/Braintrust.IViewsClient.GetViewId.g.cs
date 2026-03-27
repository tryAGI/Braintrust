#nullable enable

namespace Braintrust
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Get view<br/>
        /// Get a view object by its id
        /// </summary>
        /// <param name="viewId">
        /// View id
        /// </param>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the ACL applies to
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.View> GetViewIdAsync(
            global::System.Guid viewId,
            global::Braintrust.AclObjectType objectType,
            global::System.Guid objectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}