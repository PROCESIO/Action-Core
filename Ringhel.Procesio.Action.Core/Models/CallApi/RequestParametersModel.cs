using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ringhel.Procesio.Action.Core.Models.CallApi
{
    public class RequestParametersModel
    {
        [JsonProperty("queryParams")]
        public IList<ParameterModel> QueryParameters { get; set; } = new List<ParameterModel>();
        [JsonProperty("headers")]
        public IList<ParameterModel> HeaderParameters { get; set; } = new List<ParameterModel>();
        [JsonProperty("body")]
        public RequestBodyBase Body { get; set; }
    }
}
