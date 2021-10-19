namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP
{
    public class AuthenticationConfiguration
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public CertificateStorage Key { get; set; }
        public string KeyPassphrase { get; set; }
        public string KeyUsername { get; set; }
    }
}