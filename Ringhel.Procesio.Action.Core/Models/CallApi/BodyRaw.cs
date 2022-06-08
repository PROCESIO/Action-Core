using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ringhel.Procesio.Action.Core.Models.CallApi
{
    public class BodyRaw
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RawFormat Format { get; set; }
        public string Value { get; set; }
    }
}
