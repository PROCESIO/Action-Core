using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP
{
    public interface IFtpSftpClient
    {
        Task<List<FTPFilesInformations>> ListFileNamesWithinFolder(string path, int recursive, string type);
    }
}
