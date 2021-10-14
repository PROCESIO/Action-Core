using Newtonsoft.Json;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP
{
    public class FTPFilesInformations
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
