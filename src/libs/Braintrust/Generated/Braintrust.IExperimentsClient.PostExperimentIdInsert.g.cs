#nullable enable

namespace Braintrust
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Insert experiment events<br/>
        /// Insert a set of events into the experiment
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.InsertEventsResponse> PostExperimentIdInsertAsync(
            global::System.Guid experimentId,

            global::Braintrust.InsertExperimentEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert experiment events<br/>
        /// Insert a set of events into the experiment
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="events">
        /// A list of experiment events to insert
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.InsertEventsResponse> PostExperimentIdInsertAsync(
            global::System.Guid experimentId,
            global::System.Collections.Generic.IList<global::Braintrust.InsertExperimentEvent> events,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}