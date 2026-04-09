
#nullable enable

namespace Dust
{
    public partial class DatasourceViewsClient
    {


        private static readonly global::Dust.EndPointSecurityRequirement s_GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchSecurityRequirement0 =
            new global::Dust.EndPointSecurityRequirement
            {
                Authorizations = new global::Dust.EndPointAuthorizationRequirement[]
                {                    new global::Dust.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Dust.EndPointSecurityRequirement[] s_GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchSecurityRequirements =
            new global::Dust.EndPointSecurityRequirement[]
            {                s_GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchSecurityRequirement0,
            };
        partial void PrepareGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref string spaceId,
            ref string dsvId,
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
        partial void PrepareGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            string spaceId,
            string dsvId,
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
        partial void ProcessGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search the data source view<br/>
        /// Search the data source view identified by {dsvId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsvId"></param>
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
        public async global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourceViewsSearchResponse> GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchAsync(
            string wId,
            string spaceId,
            string dsvId,
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
            PrepareGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchArguments(
                httpClient: HttpClient,
                wId: ref wId,
                spaceId: ref spaceId,
                dsvId: ref dsvId,
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


            var __authorizations = global::Dust.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchSecurityRequirements,
                operationName: "GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchAsync");

            var __pathBuilder = new global::Dust.PathBuilder(
                path: $"/api/v1/w/{wId}/spaces/{spaceId}/data_source_views/{dsvId}/search",
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

            foreach (var __authorization in __authorizations)
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
            PrepareGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                wId: wId,
                spaceId: spaceId,
                dsvId: dsvId,
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
            ProcessGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchResponse(
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
                ProcessGetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dust.GetWSpacesDataSourceViewsSearchResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dust.GetWSpacesDataSourceViewsSearchResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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