#nullable enable

namespace Braintrust
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Partially update dataset<br/>
        /// Partially update a dataset object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Dataset> PatchDatasetIdAsync(
            global::System.Guid datasetId,

            global::Braintrust.PatchDataset request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update dataset<br/>
        /// Partially update a dataset object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="name">
        /// Name of the dataset. Within a project, dataset names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the dataset
        /// </param>
        /// <param name="tags">
        /// A list of tags for the dataset
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the dataset
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Dataset> PatchDatasetIdAsync(
            global::System.Guid datasetId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}