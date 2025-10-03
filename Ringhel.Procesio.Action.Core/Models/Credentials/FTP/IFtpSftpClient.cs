namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP;

public interface IFtpSftpClient
{
    Task<List<FTPFilesInformations>> ListFileNamesWithinFolder(string directoryPath, bool isRecursive, string type, bool useDefaultBaseFolder = false);
    Task<bool> RenameFile(string folderPath, string currentName, string newName, bool useDefaultBaseFolder = false);
    Task<bool> DeleteFile(string folder, string fileName, bool useDefaultBaseFolder = false);
    Task<List<FtpFileResult>> DeleteFiles(List<FTPFilesInformations> files, int numberOfParallelRuns);
    Task<FileModel> DownloadFile(string folder, string fileName, bool useDefaultBaseFolder = false);
    Task<List<FtpFileResult>> DownloadFiles(List<FTPFilesInformations> files, int numberOfParallelRuns);
    Task<bool> UploadFile(FileModel file, string folder);
    Task<List<FtpFileResult>> UploadFiles(List<FileModel> files, string folder, int numberOfParallelRuns);
    Task<bool> CreateFolder(string folderPath, string folderName, bool useDefaultBaseFolder = false);
    Task<bool> DeleteFolder(string folderPath, string folderName, bool useDefaultBaseFolder = false);
}
