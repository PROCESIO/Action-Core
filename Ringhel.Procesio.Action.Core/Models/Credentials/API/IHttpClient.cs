using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.API
{
    public interface IHttpClient
    {
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        /// <param name="queryParameters">Query parameters</param>
        /// <param name="headerParameters">Header parameters</param>
        /// <returns></returns>
        Task<HttpResponseMessage> GetAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters);

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        /// <param name="queryParameters">Query parameters</param>
        /// <param name="headerParameters">Header parameters</param>
        /// <returns></returns>
        Task<HttpResponseMessage> DeleteAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters);

        /// <summary>
        /// Put method.
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        /// <param name="queryParameters">Query parameters</param>
        /// <param name="headerParameters">Header parameters</param>
        /// <param name="body">Payload</param>
        /// <returns></returns>
        Task<HttpResponseMessage> PutAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters, object body);

        /// <summary>
        /// Post method.
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        /// <param name="queryParameters">Query parameters</param>
        /// <param name="headerParameters">Header parameters</param>
        /// <param name="body">Payload</param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters, object body);

        /// <summary>
        /// Patch method.
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        /// <param name="queryParameters">Query parameters</param>
        /// <param name="headerParameters">Header parameters</param>
        /// <param name="body">Payload</param>
        /// <returns></returns>
        Task<HttpResponseMessage> PatchAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters, object body);
    }
}
