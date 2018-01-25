using System;
using System.Collections.Generic;
using System.Text;
using System.IO.IsolatedStorage;
using System.Threading.Tasks;
using System.IO;
using PCLStorage;

namespace PAMO
{
    class StorageService :IStorageService
    {
       
        public StorageService()
        {

        }

        public async Task createFolder()
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("Storage", CreationCollisionOption.ReplaceExisting);
        }

        public async Task<IFile> createFile(string file_name)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("Storage", CreationCollisionOption.ReplaceExisting);
            IFile file = await folder.CreateFileAsync(file_name, CreationCollisionOption.ReplaceExisting);

            return file;
        }

        public async Task<IFile> getFileByName(string file_name)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("Storage", CreationCollisionOption.ReplaceExisting);
            IFile file = await folder.CreateFileAsync(file_name, CreationCollisionOption.OpenIfExists);

            return file;
        }

        public async Task Write(string path, string token)
        {
            IFile file =  await createFile("token.txt");
            await file.WriteAllTextAsync(token);

        }

        public async Task<String> Read(string path)
        {
            String content;
            IFile file = await getFileByName(path);
            content =  await file.ReadAllTextAsync();

            return content;
        }

        public async Task Clean(string path)
        {
            IFile file = await getFileByName(path);
            await file.DeleteAsync();
        }
    }
}
