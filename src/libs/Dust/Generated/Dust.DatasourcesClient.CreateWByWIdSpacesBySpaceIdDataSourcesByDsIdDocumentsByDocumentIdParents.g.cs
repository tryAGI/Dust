
#nullable enable

namespace Dust
{
    public partial class DatasourcesClient
    {
        partial void PrepareCreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref string spaceId,
            ref string dsId,
            ref string documentId,
            global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest request);
        partial void PrepareCreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            string spaceId,
            string dsId,
            string documentId,
            global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest request);
        partial void ProcessCreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update the parents of a document<br/>
        /// Update the parents of a document in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,

            global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsArguments(
                httpClient: HttpClient,
                wId: ref wId,
                spaceId: ref spaceId,
                dsId: ref dsId,
                documentId: ref documentId,
                request: request);

            var __pathBuilder = new global::Dust.PathBuilder(
                path: $"/api/v1/w/{wId}/spaces/{spaceId}/data_sources/{dsId}/documents/{documentId}/parents",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                wId: wId,
                spaceId: spaceId,
                dsId: dsId,
                documentId: documentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsResponse(
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
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Dust.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
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
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Dust.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// <summary>
        /// Update the parents of a document<br/>
        /// Update the parents of a document in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="parentId">
        /// Direct parent ID of the document
        /// </param>
        /// <param name="parents">
        /// Document and ancestor ids, with the following convention: parents[0] === documentId, parents[1] === parentId, and then ancestors ids in order
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,
            string? parentId = default,
            global::System.Collections.Generic.IList<string>? parents = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest
            {
                ParentId = parentId,
                Parents = parents,
            };

            await CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdParentsAsync(
                wId: wId,
                spaceId: spaceId,
                dsId: dsId,
                documentId: documentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}