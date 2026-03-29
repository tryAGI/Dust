
#nullable enable

namespace Dust
{
    public partial class PrivateAgentsClient
    {
        partial void PrepareGetWByWIdAssistantAgentConfigurationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref global::Dust.GetWAssistantAgentConfigurationsView2? view,
            ref int? limit,
            ref global::Dust.GetWAssistantAgentConfigurationsWithUsage? withUsage,
            ref global::Dust.GetWAssistantAgentConfigurationsWithAuthors2? withAuthors,
            ref global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks? withFeedbacks,
            ref global::Dust.GetWAssistantAgentConfigurationsWithEditors? withEditors,
            ref string? sort);
        partial void PrepareGetWByWIdAssistantAgentConfigurationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            global::Dust.GetWAssistantAgentConfigurationsView2? view,
            int? limit,
            global::Dust.GetWAssistantAgentConfigurationsWithUsage? withUsage,
            global::Dust.GetWAssistantAgentConfigurationsWithAuthors2? withAuthors,
            global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks? withFeedbacks,
            global::Dust.GetWAssistantAgentConfigurationsWithEditors? withEditors,
            string? sort);
        partial void ProcessGetWByWIdAssistantAgentConfigurationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWByWIdAssistantAgentConfigurationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List agent configurations<br/>
        /// Returns all agent configurations in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="view"></param>
        /// <param name="limit"></param>
        /// <param name="withUsage"></param>
        /// <param name="withAuthors"></param>
        /// <param name="withFeedbacks"></param>
        /// <param name="withEditors"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dust.GetWAssistantAgentConfigurationsResponse3> GetWByWIdAssistantAgentConfigurationsAsync(
            string wId,
            global::Dust.GetWAssistantAgentConfigurationsView2? view = default,
            int? limit = default,
            global::Dust.GetWAssistantAgentConfigurationsWithUsage? withUsage = default,
            global::Dust.GetWAssistantAgentConfigurationsWithAuthors2? withAuthors = default,
            global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks? withFeedbacks = default,
            global::Dust.GetWAssistantAgentConfigurationsWithEditors? withEditors = default,
            string? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWByWIdAssistantAgentConfigurationsArguments(
                httpClient: HttpClient,
                wId: ref wId,
                view: ref view,
                limit: ref limit,
                withUsage: ref withUsage,
                withAuthors: ref withAuthors,
                withFeedbacks: ref withFeedbacks,
                withEditors: ref withEditors,
                sort: ref sort);

            var __pathBuilder = new global::Dust.PathBuilder(
                path: $"/api/w/{wId}/assistant/agent_configurations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("view", view?.ToValueString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("withUsage", withUsage?.ToValueString())
                .AddOptionalParameter("withAuthors", withAuthors?.ToValueString())
                .AddOptionalParameter("withFeedbacks", withFeedbacks?.ToValueString())
                .AddOptionalParameter("withEditors", withEditors?.ToValueString())
                .AddOptionalParameter("sort", sort) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetWByWIdAssistantAgentConfigurationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                wId: wId,
                view: view,
                limit: limit,
                withUsage: withUsage,
                withAuthors: withAuthors,
                withFeedbacks: withFeedbacks,
                withEditors: withEditors,
                sort: sort);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWByWIdAssistantAgentConfigurationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGetWByWIdAssistantAgentConfigurationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dust.GetWAssistantAgentConfigurationsResponse3.FromJson(__content, JsonSerializerContext) ??
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Dust.GetWAssistantAgentConfigurationsResponse3.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
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
}