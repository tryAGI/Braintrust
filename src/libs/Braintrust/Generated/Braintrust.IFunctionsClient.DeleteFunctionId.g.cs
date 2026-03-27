#nullable enable

namespace Braintrust
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Delete function<br/>
        /// Delete a function object by its id
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Function2> DeleteFunctionIdAsync(
            global::System.Guid functionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}