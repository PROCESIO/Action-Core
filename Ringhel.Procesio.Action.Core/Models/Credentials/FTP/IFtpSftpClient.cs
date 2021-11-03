﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core.Models.Credentials.FTP
{
    public interface IFtpSftpClient
    {
        Task<List<FTPFilesInformations>> ListFileNamesWithinFolder(string directoryPath, bool isRecursive, string type);
        Task<bool> RenameFileWithinFolder(string directoryPath, string oldName, string newName);
    }
}
