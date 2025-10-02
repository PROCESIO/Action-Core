namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP;

public class FTPCredentialsManager
{
    public FTPCredentialsConfiguration CredentialsConfiguration { get; set; }

    public IFtpSftpClient Client { get; set; }
}
