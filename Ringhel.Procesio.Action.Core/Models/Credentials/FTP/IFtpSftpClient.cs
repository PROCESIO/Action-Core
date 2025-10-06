namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP;

/// <summary>
/// Interface for FTP/SFTP client operations, providing methods for file and folder management.
/// </summary>
public interface IFtpSftpClient
{
    /// <summary>
    /// Lists files or folders within a specified directory.
    /// </summary>
    /// <param name="directoryPath">The path of the directory to list.</param>
    /// <param name="isRecursive">Whether to list contents recursively.</param>
    /// <param name="type">The type of items to list (e.g., files or folders).</param>
    /// <param name="useDefaultBaseFolder">Whether to use the default Credential base folder as the root.</param>
    Task<List<FTPFilesInformations>> ListFileNamesWithinFolder(string directoryPath, bool isRecursive, string type, bool useDefaultBaseFolder = false);

    /// <summary>
    /// Renames a file or folder.
    /// </summary>
    /// <param name="folderPath">The path of the folder containing the item.</param>
    /// <param name="currentName">The current name of the item.</param>
    /// <param name="newName">The new name for the item.</param>
    /// <param name="useDefaultBaseFolder">Whether to use the default Credential base folder as the root.</param>
    Task<bool> RenameFile(string folderPath, string currentName, string newName, bool useDefaultBaseFolder = false);

    /// <summary>
    /// Deletes a file.
    /// </summary>
    /// <param name="folder">The folder containing the file.</param>
    /// <param name="fileName">The name of the file to delete.</param>
    /// <param name="useDefaultBaseFolder">Whether to use the default Credential base folder as the root.</param>
    Task<bool> DeleteFile(string folder, string fileName, bool useDefaultBaseFolder = false);

    /// <summary>
    /// Deletes multiple files in parallel.
    /// </summary>
    /// <param name="files">A list of file information objects to delete.</param>
    /// <param name="numberOfParallelRuns">The number of parallel operations to use.</param>
    Task<List<FtpFileResult>> DeleteFiles(List<FTPFilesInformations> files, int numberOfParallelRuns);

    /// <summary>
    /// Downloads a file.
    /// </summary>
    /// <param name="folder">The folder containing the file.</param>
    /// <param name="fileName">The name of the file to download.</param>
    /// <param name="useDefaultBaseFolder">Whether to use the default Credential base folder as the root.</param>
    Task<FileModel> DownloadFile(string folder, string fileName, bool useDefaultBaseFolder = false);

    /// <summary>
    /// Downloads multiple files in parallel.
    /// </summary>
    /// <param name="files">A list of file information objects to download.</param>
    /// <param name="numberOfParallelRuns">The number of parallel operations to use.</param>
    Task<List<FtpFileResult>> DownloadFiles(List<FTPFilesInformations> files, int numberOfParallelRuns);

    /// <summary>
    /// Uploads a file to a specified folder.
    /// </summary>
    /// <param name="file">The file model to upload.</param>
    /// <param name="folder">The destination folder.</param>
    Task<bool> UploadFile(FileModel file, string folder);

    /// <summary>
    /// Uploads multiple files in parallel to a specified folder.
    /// </summary>
    /// <param name="files">A list of file models to upload.</param>
    /// <param name="folder">The destination folder.</param>
    /// <param name="numberOfParallelRuns">The number of parallel operations to use.</param>
    Task<List<FtpFileResult>> UploadFiles(List<FileModel> files, string folder, int numberOfParallelRuns);

    /// <summary>
    /// Creates a new folder.
    /// </summary>
    /// <param name="folderPath">The path where the folder should be created.</param>
    /// <param name="folderName">The name of the new folder.</param>
    /// <param name="useDefaultBaseFolder">Whether to use the default Credential base folder as the root.</param>
    Task<bool> CreateFolder(string folderPath, string folderName, bool useDefaultBaseFolder = false);

    /// <summary>
    /// Deletes a folder.
    /// </summary>
    /// <param name="folderPath">The path of the folder to delete.</param>
    /// <param name="folderName">The name of the folder to delete.</param>
    /// <param name="useDefaultBaseFolder">Whether to use the default Credential base folder as the root.</param>
    Task<bool> DeleteFolder(string folderPath, string folderName, bool useDefaultBaseFolder = false);
}
