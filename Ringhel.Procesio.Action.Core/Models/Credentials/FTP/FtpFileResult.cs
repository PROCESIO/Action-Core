namespace Ringhel.Procesio.Action.Core.Models;

public class FtpFileResult
{
    public FileModel File { get; set; }
    public bool IsError { get; set; }
    public string Error { get; set; }
}