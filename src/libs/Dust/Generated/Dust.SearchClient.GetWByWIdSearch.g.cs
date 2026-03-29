
#nullable enable

namespace Dust
{
    public partial class SearchClient
    {
        partial void PrepareGetWByWIdSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref string query,
            ref int? limit,
            ref string? cursor,
            ref global::Dust.GetWSearchViewType? viewType,
            ref string? spaceIds,
            ref bool? includeDataSources,
            ref bool? searchSourceUrls,
            ref bool? includeTools);
        partial void PrepareGetWByWIdSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            string query,
            int? limit,
            string? cursor,
            global::Dust.GetWSearchViewType? viewType,
            string? spaceIds,
            bool? includeDataSources,
            bool? searchSourceUrls,
            bool? includeTools);
        partial void ProcessGetWByWIdSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Search for nodes in the workspace (streaming)<br/>
        /// Search for nodes in the workspace with SSE streaming
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="viewType"></param>
        /// <param name="spaceIds"></param>
        /// <param name="includeDataSources"></param>
        /// <param name="searchSourceUrls"></param>
        /// <param name="includeTools"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<string> GetWByWIdSearchAsync(
            string wId,
            string query,
            int? limit = default,
            string? cursor = default,
            global::Dust.GetWSearchViewType? viewType = default,
            string? spaceIds = default,
            bool? includeDataSources = default,
            bool? searchSourceUrls = default,
            bool? includeTools = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWByWIdSearchArguments(
                httpClient: HttpClient,
                wId: ref wId,
                query: ref query,
                limit: ref limit,
                cursor: ref cursor,
                viewType: ref viewType,
                spaceIds: ref spaceIds,
                includeDataSources: ref includeDataSources,
                searchSourceUrls: ref searchSourceUrls,
                includeTools: ref includeTools);

            var __pathBuilder = new global::Dust.PathBuilder(
                path: $"/api/v1/w/{wId}/search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("query", query)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("viewType", viewType?.ToValueString())
                .AddOptionalParameter("spaceIds", spaceIds)
                .AddOptionalParameter("includeDataSources", includeDataSources?.ToString().ToLowerInvariant())
                .AddOptionalParameter("searchSourceUrls", searchSourceUrls?.ToString().ToLowerInvariant())
                .AddOptionalParameter("includeTools", includeTools?.ToString().ToLowerInvariant()) 
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
            PrepareGetWByWIdSearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                wId: wId,
                query: query,
                limit: limit,
                cursor: cursor,
                viewType: viewType,
                spaceIds: spaceIds,
                includeDataSources: includeDataSources,
                searchSourceUrls: searchSourceUrls,
                includeTools: includeTools);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWByWIdSearchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(string), JsonSerializerContext) ??
                                       throw new global::Dust.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
    }
}