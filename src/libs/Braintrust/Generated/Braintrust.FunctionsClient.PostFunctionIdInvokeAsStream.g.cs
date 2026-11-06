
#nullable enable

namespace Braintrust
{
    public partial class FunctionsClient
    {


        private static readonly global::Braintrust.EndPointSecurityRequirement s_PostFunctionIdInvokeAsStreamSecurityRequirement0 =
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

        private static readonly global::Braintrust.EndPointSecurityRequirement s_PostFunctionIdInvokeAsStreamSecurityRequirement1 =
            new global::Braintrust.EndPointSecurityRequirement
            {
                Authorizations = new global::Braintrust.EndPointAuthorizationRequirement[]
                {
                },
            };
        private static readonly global::Braintrust.EndPointSecurityRequirement[] s_PostFunctionIdInvokeAsStreamSecurityRequirements =
            new global::Braintrust.EndPointSecurityRequirement[]
            {                s_PostFunctionIdInvokeAsStreamSecurityRequirement0,
                s_PostFunctionIdInvokeAsStreamSecurityRequirement1,
            };
        partial void PreparePostFunctionIdInvokeAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid functionId,
            global::Braintrust.InvokeApi request);
        partial void PreparePostFunctionIdInvokeAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid functionId,
            global::Braintrust.InvokeApi request);
        partial void ProcessPostFunctionIdInvokeAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Invoke function<br/>
        /// Run the specified function with the provided input and return its result. Use `version` to select a specific function version, `parent` to attach the call to a trace, and `stream` to receive results in the Braintrust SSE format.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<string> PostFunctionIdInvokeAsStreamAsync(
            global::System.Guid functionId,

            global::Braintrust.InvokeApi request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Braintrust.InvokeApi
            {
                RequestSource = request.RequestSource,
                Input = request.Input,
                Expected = request.Expected,
                Metadata = request.Metadata,
                Tags = request.Tags,
                Messages = request.Messages,
                Parent = request.Parent,
                Stream = true,
                Mode = request.Mode,
                Strict = request.Strict,
                McpAuth = request.McpAuth,
                Overrides = request.Overrides,
                EndpointName = request.EndpointName,
                Version = request.Version,
            };
            PrepareArguments(
                client: HttpClient);
            PreparePostFunctionIdInvokeAsStreamArguments(
                httpClient: HttpClient,
                functionId: ref functionId,
                request: request);


            var __authorizations = global::Braintrust.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostFunctionIdInvokeAsStreamSecurityRequirements,
                operationName: "PostFunctionIdInvokeAsStreamAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Braintrust.PathBuilder(
                                path: $"/v1/function/{functionId}/invoke",
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

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "text/event-stream");

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
                PreparePostFunctionIdInvokeAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    functionId: functionId,
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
                                operationId: "PostFunctionIdInvokeAsStream",
                                methodName: "PostFunctionIdInvokeAsStreamAsync",
                                pathTemplate: "$\"/v1/function/{functionId}/invoke\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Braintrust.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostFunctionIdInvokeAsStream",
                                methodName: "PostFunctionIdInvokeAsStreamAsync",
                                pathTemplate: "$\"/v1/function/{functionId}/invoke\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Braintrust.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Braintrust.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Braintrust.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostFunctionIdInvokeAsStream",
                                methodName: "PostFunctionIdInvokeAsStreamAsync",
                                pathTemplate: "$\"/v1/function/{functionId}/invoke\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Braintrust.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessPostFunctionIdInvokeAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostFunctionIdInvokeAsStream",
                                methodName: "PostFunctionIdInvokeAsStreamAsync",
                                pathTemplate: "$\"/v1/function/{functionId}/invoke\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Braintrust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Braintrust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostFunctionIdInvokeAsStream",
                                methodName: "PostFunctionIdInvokeAsStreamAsync",
                                pathTemplate: "$\"/v1/function/{functionId}/invoke\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                                throw global::Braintrust.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(string), JsonSerializerContext) ??
                                                       throw global::Braintrust.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Invoke function<br/>
        /// Run the specified function with the provided input and return its result. Use `version` to select a specific function version, `parent` to attach the call to a trace, and `stream` to receive results in the Braintrust SSE format.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="requestSource">
        /// A label identifying the caller, used to attribute usage
        /// </param>
        /// <param name="input">
        /// Argument to the function, which can be any JSON serializable value
        /// </param>
        /// <param name="expected">
        /// The expected output of the function
        /// </param>
        /// <param name="metadata">
        /// Any relevant metadata to log on the span. For prompts, this is available as the `metadata` template variable. For code functions, this is passed through hooks and is not added to `input`.
        /// </param>
        /// <param name="tags">
        /// Any relevant tags to log on the span.
        /// </param>
        /// <param name="messages">
        /// If the function is an LLM, additional messages to pass along to it
        /// </param>
        /// <param name="parent">
        /// Options for tracing the function call
        /// </param>
        /// <param name="mode">
        /// The mode format of the returned value (defaults to 'auto')
        /// </param>
        /// <param name="strict">
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </param>
        /// <param name="mcpAuth">
        /// Map of MCP server URL to auth credentials
        /// </param>
        /// <param name="overrides">
        /// Partial function definition to merge with the function being invoked. Fields are validated against the function type's schema at runtime. For facets: { preprocessor?, prompt?, model? }. For prompts: { model?, ... }.
        /// </param>
        /// <param name="endpointName">
        /// Name of the AI provider secret to pin this invocation to.
        /// </param>
        /// <param name="version">
        /// The version of the function
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<string> PostFunctionIdInvokeAsStreamAsync(
            global::System.Guid functionId,
            string? requestSource = default,
            object? input = default,
            object? expected = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::Braintrust.ChatCompletionMessageParam>? messages = default,
            global::Braintrust.InvokeParent? parent = default,
            global::Braintrust.StreamingMode? mode = default,
            bool? strict = default,
            global::System.Collections.Generic.Dictionary<string, global::Braintrust.InvokeApiMcpAuth2>? mcpAuth = default,
            object? overrides = default,
            string? endpointName = default,
            string? version = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Braintrust.InvokeApi
            {
                RequestSource = requestSource,
                Input = input,
                Expected = expected,
                Metadata = metadata,
                Tags = tags,
                Messages = messages,
                Parent = parent,
                Stream = true,
                Mode = mode,
                Strict = strict,
                McpAuth = mcpAuth,
                Overrides = overrides,
                EndpointName = endpointName,
                Version = version,
            };

            var __enumerable = PostFunctionIdInvokeAsStreamAsync(
                functionId: functionId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}