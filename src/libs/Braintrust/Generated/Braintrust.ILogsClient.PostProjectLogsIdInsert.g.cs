#nullable enable

namespace Braintrust
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Insert project logs events<br/>
        /// Insert a set of events into the project logs
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.InsertEventsResponse> PostProjectLogsIdInsertAsync(
            global::System.Guid projectId,

            global::Braintrust.InsertProjectLogsEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert project logs events<br/>
        /// Insert a set of events into the project logs
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="events">
        /// A list of project logs events to insert
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.InsertEventsResponse> PostProjectLogsIdInsertAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::Braintrust.InsertProjectLogsEvent> events,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}