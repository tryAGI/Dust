#nullable enable

namespace Dust
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Import skills from uploaded files<br/>
        /// Imports skills from uploaded files or ZIP archives into the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSkillsResponse> CreateWByWIdSkillsAsync(
            string wId,

            global::Dust.CreateWSkillsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import skills from uploaded files<br/>
        /// Imports skills from uploaded files or ZIP archives into the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.CreateWSkillsResponse>> CreateWByWIdSkillsAsResponseAsync(
            string wId,

            global::Dust.CreateWSkillsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import skills from uploaded files<br/>
        /// Imports skills from uploaded files or ZIP archives into the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="files">
        /// Skill files or ZIP archives to import.
        /// </param>
        /// <param name="names">
        /// Optional skill names to import from the uploaded files.
        /// </param>
        /// <param name="onConflict">
        /// Conflict handling strategy. Defaults to error.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSkillsResponse> CreateWByWIdSkillsAsync(
            string wId,
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Collections.Generic.IList<string>? names = default,
            global::Dust.CreateWSkillsRequestOnConflict? onConflict = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Import skills from uploaded files<br/>
        /// Imports skills from uploaded files or ZIP archives into the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="files">
        /// Skill files or ZIP archives to import.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="names">
        /// Optional skill names to import from the uploaded files.
        /// </param>
        /// <param name="onConflict">
        /// Conflict handling strategy. Defaults to error.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSkillsResponse> CreateWByWIdSkillsAsync(
            string wId,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::System.Collections.Generic.IList<string>? names = default,
            global::Dust.CreateWSkillsRequestOnConflict? onConflict = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import skills from uploaded files<br/>
        /// Imports skills from uploaded files or ZIP archives into the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="files">
        /// Skill files or ZIP archives to import.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="names">
        /// Optional skill names to import from the uploaded files.
        /// </param>
        /// <param name="onConflict">
        /// Conflict handling strategy. Defaults to error.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.CreateWSkillsResponse>> CreateWByWIdSkillsAsResponseAsync(
            string wId,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::System.Collections.Generic.IList<string>? names = default,
            global::Dust.CreateWSkillsRequestOnConflict? onConflict = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}