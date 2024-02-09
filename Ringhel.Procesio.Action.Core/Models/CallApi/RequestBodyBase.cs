using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ringhel.Procesio.Action.Core.Models.CallApi
{
    public class RequestBodyBase
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public BodyType Type { get; set; }
        public RequestBodyValue Value { get; set; }
    }
}
