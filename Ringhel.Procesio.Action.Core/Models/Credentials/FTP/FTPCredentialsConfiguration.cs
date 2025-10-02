namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP;

public class FTPCredentialsConfiguration
{
    public string Host { get; set; }
    public int Port { get; set; }
    public FtpClientTypes Protocol { get; set; }
    public bool IgnoreCertificateWarnings { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Path { get; set; }
    public AuthenticationConfiguration Authentication { get; set; }
}
