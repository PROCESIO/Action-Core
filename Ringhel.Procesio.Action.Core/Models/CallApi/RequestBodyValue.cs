using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ringhel.Procesio.Action.Core.Models.CallApi
{
    public class RequestBodyValue
    {
        [JsonProperty("BINARY")]
        public string Binary { get; set; }
        [JsonProperty("RAW")]
        public BodyRaw Raw { get; set; }
        [JsonProperty("FORM_DATA")]
        public IList<BodyFormDataValue> FormData { get; set; }
        [JsonProperty("X_WWW_FORM_URLENCODED")]
        public IList<ParameterModel> FormUrlEncoded { get; set; }
    }
}
