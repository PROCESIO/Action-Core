namespace Ringhel.Procesio.Action.Core.Models.Credentials.API;

public interface IHttpClient
{
    /// <summary>
    /// Get method.
    /// </summary>
    /// <param name="endpoint">Endpoint</param>
    /// <param name="queryParameters">Query parameters</param>
    /// <param name="headerParameters">Header parameters</param>
    /// <param name="body">Payload</param>
    /// <param name="files">Files Payload</param>
    /// <param name="httpContentType">Content Type</param>
    /// <returns>Response</returns>
    Task<HttpResponseMessage> GetAsync(
        string endpoint,
        Dictionary<string, string> queryParameters,
        Dictionary<string, string> headerParameters,
        object body = null,
        object files = null,
        HttpContentType httpContentType = HttpContentType.Json);

    /// <summary>
    /// Delete method.
    /// </summary>
    /// <param name="endpoint">Endpoint</param>
    /// <param name="queryParameters">Query parameters</param>
    /// <param name="headerParameters">Header parameters</param>
    /// <param name="body">Payload</param>
    /// <param name="files">Files Payload</param>
    /// <param name="httpContentType">Content Type</param>
    /// <returns>Response</returns>
    Task<HttpResponseMessage> DeleteAsync(
        string endpoint,
        Dictionary<string, string> queryParameters,
        Dictionary<string, string> headerParameters,
        object body = null,
        object files = null,
        HttpContentType httpContentType = HttpContentType.Json);

    /// <summary>
    /// Put method.
    /// </summary>
    /// <param name="endpoint">Endpoint</param>
    /// <param name="queryParameters">Query parameters</param>
    /// <param name="headerParameters">Header parameters</param>
    /// <param name="body">Payload</param>
    /// <param name="files">Files Payload</param>
    /// <param name="httpContentType">Content Type</param>
    /// <returns>Response</returns>
    Task<HttpResponseMessage> PutAsync(
        string endpoint,
        Dictionary<string, string> queryParameters,
        Dictionary<string, string> headerParameters,
        object body,
        object files = null,
        HttpContentType httpContentType = HttpContentType.Json);

    /// <summary>
    /// Post method.
    /// </summary>
    /// <param name="endpoint">Endpoint</param>
    /// <param name="queryParameters">Query parameters</param>
    /// <param name="headerParameters">Header parameters</param>
    /// <param name="body">Payload</param>
    /// <param name="files">Files Payload</param>
    /// <param name="httpContentType">Content Type</param>
    /// <returns>Response</returns>
    Task<HttpResponseMessage> PostAsync(
        string endpoint,
        Dictionary<string, string> queryParameters,
        Dictionary<string, string> headerParameters,
        object body,
        object files = null,
        HttpContentType httpContentType = HttpContentType.Json);

    /// <summary>
    /// Patch method.
    /// </summary>
    /// <param name="endpoint">Endpoint</param>
    /// <param name="queryParameters">Query parameters</param>
    /// <param name="headerParameters">Header parameters</param>
    /// <param name="body">Payload</param>
    /// <param name="files">Files Payload</param>
    /// <param name="httpContentType">Content Type</param>
    /// <returns>Response</returns>
    Task<HttpResponseMessage> PatchAsync(
        string endpoint,
        Dictionary<string, string> queryParameters,
        Dictionary<string, string> headerParameters,
        object body,
        object files = null,
        HttpContentType httpContentType = HttpContentType.Json);

    /// <summary>
    /// Set custom TimeOut for the HttpClient.
    /// </summary>
    /// <param name="secondsTimeOut">Timeout in seconds</param>
    void SetTimeOut(int secondsTimeOut);

    /// <summary>
    /// Replace the base URL (scheme, host, port and base path) that every later request is built on.
    /// Query pairs on the URL are added to the client's query parameters; pairs the credential already
    /// supplies win. Header parameters and the authorization configuration are kept, so the credential's
    /// token, API key or basic authentication is sent to the new host. Pass relative endpoints afterwards.
    /// The stored credential is not changed.
    /// </summary>
    /// <param name="baseUrl">An absolute http or https URL.</param>
    /// <exception cref="ArgumentException">The URL is null, empty, relative or not http or https.</exception>
    /// <exception cref="NotSupportedException">The client does not support changing the base URL.</exception>
    void SetBaseUrl(string baseUrl) =>
        throw new NotSupportedException("This HTTP client does not support changing the base URL.");
}
