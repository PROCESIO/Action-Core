namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP;

public class FtpFileResult
{
    public FileModel File { get; set; }
    public bool IsError { get; set; }
    public string Error { get; set; }
}
