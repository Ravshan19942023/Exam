

using Domain;

namespace Infrastructure;

public interface IPostService
{
    Task<bool> AddPostAsync(AddPostDto post);
    Task<bool> DeletePostAsync(int id);
    Task<bool> UpdatePostAsync(UpdatePostDto post);
    Task<bool> GetPostAsync(int id);
    Task<List<GetPostDto>> GetAllPostsAsync();
}
