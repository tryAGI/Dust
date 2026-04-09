
#nullable enable

namespace Dust
{
    public partial class McpClient
    {


        private static readonly global::Dust.EndPointSecurityRequirement s_GetWByWIdMcpRequestsSecurityRequirement0 =
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
        private static readonly global::Dust.EndPointSecurityRequirement[] s_GetWByWIdMcpRequestsSecurityRequirements =
            new global::Dust.EndPointSecurityRequirement[]
            {                s_GetWByWIdMcpRequestsSecurityRequirement0,
            };
        partial void PrepareGetWByWIdMcpRequestsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref string serverId,
            ref string? lastEventId);
        partial void PrepareGetWByWIdMcpRequestsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            string serverId,
            string? lastEventId);
        partial void ProcessGetWByWIdMcpRequestsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Stream MCP tool requests for a workspace<br/>
        /// [Documentation](https://docs.dust.tt/docs/client-side-mcp-server)<br/>
        /// Server-Sent Events (SSE) endpoint that streams MCP tool requests for a workspace.<br/>
        /// This endpoint is used by client-side MCP servers to listen for tool requests in real-time.<br/>
        /// The connection will remain open and events will be sent as new tool requests are made.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="serverId"></param>
        /// <param name="lastEventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Dust.GetWMcpRequestsResponse> GetWByWIdMcpRequestsAsync(
            string wId,
            string serverId,
            string? lastEventId = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWByWIdMcpRequestsArguments(
                httpClient: HttpClient,
                wId: ref wId,
                serverId: ref serverId,
                lastEventId: ref lastEventId);


            var __authorizations = global::Dust.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetWByWIdMcpRequestsSecurityRequirements,
                operationName: "GetWByWIdMcpRequestsAsync");

            var __pathBuilder = new global::Dust.PathBuilder(
                path: $"/api/v1/w/{wId}/mcp/requests",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("serverId", serverId)
                .AddOptionalParameter("lastEventId", lastEventId) 
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
            PrepareGetWByWIdMcpRequestsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                wId: wId,
                serverId: serverId,
                lastEventId: lastEventId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWByWIdMcpRequestsResponse(
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

                var __streamedResponse = global::Dust.GetWMcpRequestsResponse.FromJson(__content, JsonSerializerContext) ??
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