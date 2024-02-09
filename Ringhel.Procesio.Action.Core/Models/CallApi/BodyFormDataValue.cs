using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ringhel.Procesio.Action.Core.Models.CallApi
{
    public class BodyFormDataValue : ParameterModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public FormDataType Type { get; set; }
    }
}
