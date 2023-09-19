

using Domain;
using Microsoft.AspNetCore.Http;

namespace Infrastructure;

public interface IFileService
{
    Task<string> AddFile(string folder, IFormFile file);
    Task<bool> DeleteFile(string folder, string fileName);
}
