namespace Ringhel.Procesio.Action.Core.Models
{
    public class DbCredentialsConfiguration
    {
        public string ServerName { get; set; }
        public DbClientType ServerType { get; set; }
        public DbProtocolType ProtocolType { get; set; }
        public int? PortNumber { get; set; }
        public DbAuthenticationType AuthenticationType { get; set; }
        public bool? Encrypt { get; set; }
        public bool? Pooling { get; set; }
        public bool? TrustServerCertificate { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
