using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

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
    /// <param name="httpContentType">Content Type</param>
    /// <returns>Response</returns>
    Task<HttpResponseMessage> GetAsync(
        string endpoint,
        Dictionary<string, string> queryParameters,
        Dictionary<string, string> headerParameters,
        object body = null,
        HttpContentType httpContentType = HttpContentType.Json);

    /// <summary>
    /// Delete method.
    /// </summary>
    /// <param name="endpoint">Endpoint</param>
    /// <param name="queryParameters">Query parameters</param>
    /// <param name="headerParameters">Header parameters</param>
    /// <param name="body">Payload</param>
    /// <param name="httpContentType">Content Type</param>
    /// <returns>Response</returns>
    Task<HttpResponseMessage> DeleteAsync(
        string endpoint,
        Dictionary<string, string> queryParameters,
        Dictionary<string, string> headerParameters,
        object body = null,
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
}
