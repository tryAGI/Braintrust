#nullable enable

namespace Braintrust
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Insert dataset events<br/>
        /// Insert a set of events into the dataset
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.InsertEventsResponse> PostDatasetIdInsertAsync(
            global::System.Guid datasetId,

            global::Braintrust.InsertDatasetEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert dataset events<br/>
        /// Insert a set of events into the dataset
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="events">
        /// A list of dataset events to insert
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.InsertEventsResponse> PostDatasetIdInsertAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::Braintrust.InsertDatasetEvent> events,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}