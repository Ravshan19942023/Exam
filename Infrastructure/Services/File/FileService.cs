

using Microsoft.AspNetCore.Http;

namespace Infrastructure;

public class FileService : IFileService
{
    public Task<string> AddFile(string folder, IFormFile file)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteFile(string folder, string fileName)
    {
        throw new NotImplementedException();
    }
}
