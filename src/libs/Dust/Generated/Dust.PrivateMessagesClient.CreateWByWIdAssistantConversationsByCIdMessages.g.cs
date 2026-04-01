
#nullable enable

namespace Dust
{
    public partial class PrivateMessagesClient
    {
        partial void PrepareCreateWByWIdAssistantConversationsByCIdMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string wId,
            ref string cId,
            global::Dust.CreateWAssistantConversationsMessagesRequest request);
        partial void PrepareCreateWByWIdAssistantConversationsByCIdMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string wId,
            string cId,
            global::Dust.CreateWAssistantConversationsMessagesRequest request);
        partial void ProcessCreateWByWIdAssistantConversationsByCIdMessagesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateWByWIdAssistantConversationsByCIdMessagesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Post a message to a conversation<br/>
        /// Post a new user message to an existing conversation, triggering agent responses.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesResponse> CreateWByWIdAssistantConversationsByCIdMessagesAsync(
            string wId,
            string cId,

            global::Dust.CreateWAssistantConversationsMessagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateWByWIdAssistantConversationsByCIdMessagesArguments(
                httpClient: HttpClient,
                wId: ref wId,
                cId: ref cId,
                request: request);

            var __pathBuilder = new global::Dust.PathBuilder(
                path: $"/api/w/{wId}/assistant/conversations/{cId}/messages",
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
            PrepareCreateWByWIdAssistantConversationsByCIdMessagesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                wId: wId,
                cId: cId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateWByWIdAssistantConversationsByCIdMessagesResponse(
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
                ProcessCreateWByWIdAssistantConversationsByCIdMessagesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Dust.CreateWAssistantConversationsMessagesResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Dust.CreateWAssistantConversationsMessagesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Post a message to a conversation<br/>
        /// Post a new user message to an existing conversation, triggering agent responses.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="content"></param>
        /// <param name="mentions"></param>
        /// <param name="context"></param>
        /// <param name="skipToolsValidation"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantConversationsMessagesResponse> CreateWByWIdAssistantConversationsByCIdMessagesAsync(
            string wId,
            string cId,
            string content,
            global::System.Collections.Generic.IList<global::Dust.PrivateMention> mentions,
            global::Dust.CreateWAssistantConversationsMessagesRequestContext context,
            bool? skipToolsValidation = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::Dust.CreateWAssistantConversationsMessagesRequest
            {
                Content = content,
                Mentions = mentions,
                Context = context,
                SkipToolsValidation = skipToolsValidation,
            };

            return await CreateWByWIdAssistantConversationsByCIdMessagesAsync(
                wId: wId,
                cId: cId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}