using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.API
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> GetAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters);

        Task<HttpResponseMessage> DeleteAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters);

        Task<HttpResponseMessage> PutAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters, object body);

        Task<HttpResponseMessage> PostAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters, object body);

        Task<HttpResponseMessage> PatchAsync(string endpoint, Dictionary<string, string> queryParameters, Dictionary<string, string> headerParameters, object body);
    }
}
