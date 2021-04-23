namespace Ringhel.Procesio.Action.Core.Models.Credentials.API
{
    public class APICredentialsConfiguration 
    {
        public string Schema { get; set; }

        public string Path { get; set; }

        public string PrefixEndpoint { get; set; }

        public int PortNumber { get; set; }

        public AuthorizationConfiguration Authorization { get; set; }
    }
}
