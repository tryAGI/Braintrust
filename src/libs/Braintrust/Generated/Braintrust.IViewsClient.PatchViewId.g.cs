#nullable enable

namespace Braintrust
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Partially update view<br/>
        /// Partially update a view object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="viewId">
        /// View id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.View> PatchViewIdAsync(
            global::System.Guid viewId,

            global::Braintrust.PatchView request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update view<br/>
        /// Partially update a view object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="viewId">
        /// View id
        /// </param>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the view applies to
        /// </param>
        /// <param name="viewType">
        /// Type of object that the view corresponds to.
        /// </param>
        /// <param name="name">
        /// Name of the view
        /// </param>
        /// <param name="viewData">
        /// The view definition
        /// </param>
        /// <param name="options">
        /// Options for the view in the app
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the view
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.View> PatchViewIdAsync(
            global::System.Guid viewId,
            global::Braintrust.AclObjectType objectType,
            global::System.Guid objectId,
            global::Braintrust.PatchViewViewType? viewType = default,
            string? name = default,
            global::Braintrust.ViewData? viewData = default,
            global::Braintrust.ViewOptions? options = default,
            global::System.Guid? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}