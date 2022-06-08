using Newtonsoft.Json;

namespace Ringhel.Procesio.Action.Core.Models.CallApi
{
    public class ParameterModel
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public object Value { get; set; }
        [JsonProperty("enabled")]
        public bool IsEnabled { get; set; }
    }
}
