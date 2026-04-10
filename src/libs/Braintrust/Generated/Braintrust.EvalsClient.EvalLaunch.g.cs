
#nullable enable

namespace Braintrust
{
    public partial class EvalsClient
    {


        private static readonly global::Braintrust.EndPointSecurityRequirement s_EvalLaunchSecurityRequirement0 =
            new global::Braintrust.EndPointSecurityRequirement
            {
                Authorizations = new global::Braintrust.EndPointAuthorizationRequirement[]
                {                    new global::Braintrust.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };

        private static readonly global::Braintrust.EndPointSecurityRequirement s_EvalLaunchSecurityRequirement1 =
            new global::Braintrust.EndPointSecurityRequirement
            {
                Authorizations = new global::Braintrust.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::Braintrust.EndPointSecurityRequirement[] s_EvalLaunchSecurityRequirements =
            new global::Braintrust.EndPointSecurityRequirement[]
            {                s_EvalLaunchSecurityRequirement0,
                s_EvalLaunchSecurityRequirement1,
            };
        partial void PrepareEvalLaunchArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Braintrust.RunEval request);
        partial void PrepareEvalLaunchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Braintrust.RunEval request);
        partial void ProcessEvalLaunchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEvalLaunchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Launch an eval<br/>
        /// Launch an evaluation. This is the API-equivalent of the `Eval` function that is built into the Braintrust SDK. In the Eval API, you provide pointers to a dataset, task function, and scoring functions. The API will then run the evaluation, create an experiment, and return the results along with a link to the experiment. To learn more about evals, see the [Evals guide](https://www.braintrust.dev/docs/evaluate).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Braintrust.SummarizeExperimentResponse> EvalLaunchAsync(

            global::Braintrust.RunEval request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEvalLaunchArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Braintrust.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EvalLaunchSecurityRequirements,
                operationName: "EvalLaunchAsync");

            using var __timeoutCancellationTokenSource = global::Braintrust.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Braintrust.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Braintrust.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Braintrust.PathBuilder(
                                path: "/v1/eval",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Braintrust.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Braintrust.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareEvalLaunchRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Braintrust.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EvalLaunch",
                                methodName: "EvalLaunchAsync",
                                pathTemplate: "\"/v1/eval\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EvalLaunch",
                                methodName: "EvalLaunchAsync",
                                pathTemplate: "\"/v1/eval\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Braintrust.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Braintrust.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EvalLaunch",
                                methodName: "EvalLaunchAsync",
                                pathTemplate: "\"/v1/eval\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Braintrust.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessEvalLaunchResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EvalLaunch",
                                methodName: "EvalLaunchAsync",
                                pathTemplate: "\"/v1/eval\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EvalLaunch",
                                methodName: "EvalLaunchAsync",
                                pathTemplate: "\"/v1/eval\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessEvalLaunchResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Braintrust.SummarizeExperimentResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Braintrust.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Braintrust.SummarizeExperimentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Braintrust.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Launch an eval<br/>
        /// Launch an evaluation. This is the API-equivalent of the `Eval` function that is built into the Braintrust SDK. In the Eval API, you provide pointers to a dataset, task function, and scoring functions. The API will then run the evaluation, create an experiment, and return the results along with a link to the experiment. To learn more about evals, see the [Evals guide](https://www.braintrust.dev/docs/evaluate).
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project to run the eval in
        /// </param>
        /// <param name="data">
        /// The dataset to use
        /// </param>
        /// <param name="name">
        /// The name of the eval to run when multiple evals available
        /// </param>
        /// <param name="parameters">
        /// Values for any parameters used in the eval
        /// </param>
        /// <param name="task">
        /// The function to evaluate
        /// </param>
        /// <param name="scores">
        /// The functions to score the eval on
        /// </param>
        /// <param name="experimentName">
        /// An optional name for the experiment created by this eval. If it conflicts with an existing experiment, it will be suffixed with a unique identifier.
        /// </param>
        /// <param name="metadata">
        /// Optional experiment-level metadata to store about the evaluation. You can later use this to slice &amp; dice across experiments.
        /// </param>
        /// <param name="parent"></param>
        /// <param name="stream">
        /// Whether to stream the results of the eval. If true, the request will return two events: one to indicate the experiment has started, and another upon completion. If false, the request will return the evaluation's summary upon completion.
        /// </param>
        /// <param name="trialCount">
        /// The number of times to run the evaluator per input. This is useful for evaluating applications that have non-deterministic behavior and gives you both a stronger aggregate measure and a sense of the variance in the results.
        /// </param>
        /// <param name="isPublic">
        /// Whether the experiment should be public. Defaults to false.
        /// </param>
        /// <param name="timeout">
        /// The maximum duration, in milliseconds, to run the evaluation. Defaults to undefined, in which case there is no timeout.
        /// </param>
        /// <param name="maxConcurrency">
        /// The maximum number of tasks/scorers that will be run concurrently. Defaults to 10. If null is provided, no max concurrency will be used.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="baseExperimentName">
        /// An optional experiment name to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </param>
        /// <param name="baseExperimentId">
        /// An optional experiment id to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </param>
        /// <param name="gitMetadataSettings">
        /// Optional settings for collecting git metadata. By default, will collect all git metadata fields allowed in org-level settings.
        /// </param>
        /// <param name="repoInfo"></param>
        /// <param name="strict">
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </param>
        /// <param name="stopToken">
        /// The token to stop the run
        /// </param>
        /// <param name="extraMessages">
        /// A template path of extra messages to append to the conversion. These messages will be appended to the end of the conversation, after the last message.
        /// </param>
        /// <param name="tags">
        /// Optional tags that will be added to the experiment.
        /// </param>
        /// <param name="mcpAuth"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Braintrust.SummarizeExperimentResponse> EvalLaunchAsync(
            string projectId,
            global::Braintrust.AnyOf<global::Braintrust.RunEvalDataDatasetId, global::Braintrust.RunEvalDataProjectDatasetName, global::Braintrust.RunEvalDataDatasetRows> data,
            global::Braintrust.FunctionId task,
            global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.FunctionId?, object>> scores,
            string? name = default,
            global::System.Collections.Generic.Dictionary<string, object?>? parameters = default,
            string? experimentName = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::Braintrust.AllOf<global::Braintrust.InvokeParent?, object>? parent = default,
            bool? stream = default,
            double? trialCount = default,
            bool? isPublic = default,
            double? timeout = default,
            double? maxConcurrency = default,
            string? baseExperimentName = default,
            string? baseExperimentId = default,
            global::Braintrust.GitMetadataSettings? gitMetadataSettings = default,
            global::Braintrust.AllOf<global::Braintrust.RepoInfo, object>? repoInfo = default,
            bool? strict = default,
            string? stopToken = default,
            string? extraMessages = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, global::Braintrust.RunEvalMcpAuth2>? mcpAuth = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Braintrust.RunEval
            {
                ProjectId = projectId,
                Data = data,
                Name = name,
                Parameters = parameters,
                Task = task,
                Scores = scores,
                ExperimentName = experimentName,
                Metadata = metadata,
                Parent = parent,
                Stream = stream,
                TrialCount = trialCount,
                IsPublic = isPublic,
                Timeout = timeout,
                MaxConcurrency = maxConcurrency,
                BaseExperimentName = baseExperimentName,
                BaseExperimentId = baseExperimentId,
                GitMetadataSettings = gitMetadataSettings,
                RepoInfo = repoInfo,
                Strict = strict,
                StopToken = stopToken,
                ExtraMessages = extraMessages,
                Tags = tags,
                McpAuth = mcpAuth,
            };

            return await EvalLaunchAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}