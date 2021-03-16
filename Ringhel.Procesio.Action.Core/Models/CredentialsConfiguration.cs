namespace Ringhel.Procesio.Action.Core.Models
{
    public class CredentialsConfiguration : ICredentialsConfiguration
    {
        public string Schema { get; set; }

        public string Path { get; set; }

        public int PortNumber { get; set; }

        public IAuthorizationConfiguration Authorization { get; set; }
    }
}
