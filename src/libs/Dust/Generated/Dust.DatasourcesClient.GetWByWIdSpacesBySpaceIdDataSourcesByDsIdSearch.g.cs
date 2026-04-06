
#nullable enable

namespace Dust
{
    public partial class DatasourcesClient
    {
        partial void PrepareGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref string spaceId,
            ref string dsId,
            ref string query,
            ref double topK,
            ref bool fullText,
            ref double? targetDocumentTokens,
            ref double? timestampGt,
            ref double? timestampLt,
            ref string? tagsIn,
            ref string? tagsNot,
            ref string? parentsIn,
            ref string? parentsNot);
        partial void PrepareGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            string spaceId,
            string dsId,
            string query,
            double topK,
            bool fullText,
            double? targetDocumentTokens,
            double? timestampGt,
            double? timestampLt,
            string? tagsIn,
            string? tagsNot,
            string? parentsIn,
            string? parentsNot);
        partial void ProcessGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search the data source<br/>
        /// Search the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="query"></param>
        /// <param name="topK"></param>
        /// <param name="fullText"></param>
        /// <param name="targetDocumentTokens"></param>
        /// <param name="timestampGt"></param>
        /// <param name="timestampLt"></param>
        /// <param name="tagsIn"></param>
        /// <param name="tagsNot"></param>
        /// <param name="parentsIn"></param>
        /// <param name="parentsNot"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourcesSearchResponse> GetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchAsync(
            string wId,
            string spaceId,
            string dsId,
            string query,
            double topK,
            bool fullText,
            double? targetDocumentTokens = default,
            double? timestampGt = default,
            double? timestampLt = default,
            string? tagsIn = default,
            string? tagsNot = default,
            string? parentsIn = default,
            string? parentsNot = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchArguments(
                httpClient: HttpClient,
                wId: ref wId,
                spaceId: ref spaceId,
                dsId: ref dsId,
                query: ref query,
                topK: ref topK,
                fullText: ref fullText,
                targetDocumentTokens: ref targetDocumentTokens,
                timestampGt: ref timestampGt,
                timestampLt: ref timestampLt,
                tagsIn: ref tagsIn,
                tagsNot: ref tagsNot,
                parentsIn: ref parentsIn,
                parentsNot: ref parentsNot);

            var __pathBuilder = new global::Dust.PathBuilder(
                path: $"/api/v1/w/{wId}/spaces/{spaceId}/data_sources/{dsId}/search",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("query", query)
                .AddRequiredParameter("top_k", topK.ToString()!)
                .AddRequiredParameter("full_text", fullText.ToString().ToLowerInvariant())
                .AddOptionalParameter("target_document_tokens", targetDocumentTokens?.ToString())
                .AddOptionalParameter("timestamp_gt", timestampGt?.ToString())
                .AddOptionalParameter("timestamp_lt", timestampLt?.ToString())
                .AddOptionalParameter("tags_in", tagsIn)
                .AddOptionalParameter("tags_not", tagsNot)
                .AddOptionalParameter("parents_in", parentsIn)
                .AddOptionalParameter("parents_not", parentsNot) 
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
            PrepareGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                wId: wId,
                spaceId: spaceId,
                dsId: dsId,
                query: query,
                topK: topK,
                fullText: fullText,
                targetDocumentTokens: targetDocumentTokens,
                timestampGt: timestampGt,
                timestampLt: timestampLt,
                tagsIn: tagsIn,
                tagsNot: tagsNot,
                parentsIn: parentsIn,
                parentsNot: parentsNot);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Dust.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 405)
            {
                string? __content_405 = null;
                global::System.Exception? __exception_405 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_405 = __ex;
                }

                throw new global::Dust.ApiException(
                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_405,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_405,
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
                ProcessGetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dust.GetWSpacesDataSourcesSearchResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dust.GetWSpacesDataSourcesSearchResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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