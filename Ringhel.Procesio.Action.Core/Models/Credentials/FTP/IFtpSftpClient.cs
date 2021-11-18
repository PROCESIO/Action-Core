using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP
{
    public interface IFtpSftpClient
    {
        Task<List<FTPFilesInformations>> ListFileNamesWithinFolder(string directoryPath, bool isRecursive, string type);
        Task<bool> RenameFile(string folderPath, string currentName, string newName);
        Task<bool> DeleteFile(string folder, string fileName);
        Task<FileModel> DownloadFile(string folder, string fileName);
        Task<bool> UploadFile(FileModel file, string folder);
        Task<bool> CreateFolder(string folderPath, string folderName);
    }
}
