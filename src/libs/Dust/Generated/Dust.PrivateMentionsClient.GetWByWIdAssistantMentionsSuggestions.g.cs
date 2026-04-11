
#nullable enable

namespace Dust
{
    public partial class PrivateMentionsClient
    {

        private static readonly global::Dust.AutoSDKServer[] s_GetWByWIdAssistantMentionsSuggestionsServers = new global::Dust.AutoSDKServer[]
        {            new global::Dust.AutoSDKServer(
                id: "https-dust-tt",
                name: "Dust.tt API (us-central1)",
                url: "https://dust.tt/",
                description: "Dust.tt API (us-central1)"),
            new global::Dust.AutoSDKServer(
                id: "https-eu-dust-tt",
                name: "Dust.tt API (europe-west1)",
                url: "https://eu.dust.tt/",
                description: "Dust.tt API (europe-west1)"),
        };


        private static readonly global::Dust.EndPointSecurityRequirement s_GetWByWIdAssistantMentionsSuggestionsSecurityRequirement0 =
            new global::Dust.EndPointSecurityRequirement
            {
                Authorizations = new global::Dust.EndPointAuthorizationRequirement[]
                {                    new global::Dust.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Dust.EndPointSecurityRequirement[] s_GetWByWIdAssistantMentionsSuggestionsSecurityRequirements =
            new global::Dust.EndPointSecurityRequirement[]
            {                s_GetWByWIdAssistantMentionsSuggestionsSecurityRequirement0,
            };
        partial void PrepareGetWByWIdAssistantMentionsSuggestionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref string? query,
            ref global::Dust.GetWAssistantMentionsSuggestionsSelect? select,
            ref global::Dust.GetWAssistantMentionsSuggestionsCurrent? current,
            ref string? spaceId);
        partial void PrepareGetWByWIdAssistantMentionsSuggestionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            string? query,
            global::Dust.GetWAssistantMentionsSuggestionsSelect? select,
            global::Dust.GetWAssistantMentionsSuggestionsCurrent? current,
            string? spaceId);
        partial void ProcessGetWByWIdAssistantMentionsSuggestionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWByWIdAssistantMentionsSuggestionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get mention suggestions<br/>
        /// Returns mention suggestions for the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="query"></param>
        /// <param name="select"></param>
        /// <param name="current"></param>
        /// <param name="spaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dust.GetWAssistantMentionsSuggestionsResponse2> GetWByWIdAssistantMentionsSuggestionsAsync(
            string wId,
            string? query = default,
            global::Dust.GetWAssistantMentionsSuggestionsSelect? select = default,
            global::Dust.GetWAssistantMentionsSuggestionsCurrent? current = default,
            string? spaceId = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWByWIdAssistantMentionsSuggestionsArguments(
                httpClient: HttpClient,
                wId: ref wId,
                query: ref query,
                select: ref select,
                current: ref current,
                spaceId: ref spaceId);


            var __authorizations = global::Dust.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetWByWIdAssistantMentionsSuggestionsSecurityRequirements,
                operationName: "GetWByWIdAssistantMentionsSuggestionsAsync");

            using var __timeoutCancellationTokenSource = global::Dust.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Dust.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Dust.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Dust.PathBuilder(
                                path: $"/api/w/{wId}/assistant/mentions/suggestions",
                                baseUri: ResolveBaseUri(
                                servers: s_GetWByWIdAssistantMentionsSuggestionsServers,
                                defaultBaseUrl: "https://dust.tt/")); 
                            __pathBuilder
                                .AddOptionalParameter("query", query)
                                .AddOptionalParameter("select", select?.ToValueString())
                                .AddOptionalParameter("current", current?.ToValueString())
                                .AddOptionalParameter("spaceId", spaceId) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Dust.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Dust.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetWByWIdAssistantMentionsSuggestionsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    wId: wId,
                    query: query,
                    select: select,
                    current: current,
                    spaceId: spaceId);

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
                    await global::Dust.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Dust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getWByWIdAssistantMentionsSuggestions",
                                methodName: "GetWByWIdAssistantMentionsSuggestionsAsync",
                                pathTemplate: "$\"/api/w/{wId}/assistant/mentions/suggestions\"",
                                httpMethod: "GET",
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
                        await global::Dust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getWByWIdAssistantMentionsSuggestions",
                                methodName: "GetWByWIdAssistantMentionsSuggestionsAsync",
                                pathTemplate: "$\"/api/w/{wId}/assistant/mentions/suggestions\"",
                                httpMethod: "GET",
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
                        await global::Dust.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Dust.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Dust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getWByWIdAssistantMentionsSuggestions",
                                methodName: "GetWByWIdAssistantMentionsSuggestionsAsync",
                                pathTemplate: "$\"/api/w/{wId}/assistant/mentions/suggestions\"",
                                httpMethod: "GET",
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
                        await global::Dust.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
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
                ProcessGetWByWIdAssistantMentionsSuggestionsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Dust.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Dust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getWByWIdAssistantMentionsSuggestions",
                                methodName: "GetWByWIdAssistantMentionsSuggestionsAsync",
                                pathTemplate: "$\"/api/w/{wId}/assistant/mentions/suggestions\"",
                                httpMethod: "GET",
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
                    await global::Dust.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Dust.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getWByWIdAssistantMentionsSuggestions",
                                methodName: "GetWByWIdAssistantMentionsSuggestionsAsync",
                                pathTemplate: "$\"/api/w/{wId}/assistant/mentions/suggestions\"",
                                httpMethod: "GET",
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
                            // 
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::Dust.ApiException(
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_401,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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
                                ProcessGetWByWIdAssistantMentionsSuggestionsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Dust.GetWAssistantMentionsSuggestionsResponse2.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Dust.ApiException(
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
                                        await global::Dust.GetWAssistantMentionsSuggestionsResponse2.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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

                                    throw new global::Dust.ApiException(
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
    }
}