#nullable enable

namespace Braintrust
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Delete environment
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Environment> DeleteEnvironmentAsync(
            global::System.Guid environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}