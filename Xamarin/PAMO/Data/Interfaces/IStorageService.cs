using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PCLStorage;

namespace PAMO{

    public interface IStorageService
    {
        Task createFolder();
        Task<IFile> createFile(string file_name);
        Task<IFile> getFileByName(string file_name);

        Task Write(string path, string token);
        Task<String> Read(string path);
        Task Clean(string path);
    }
}
