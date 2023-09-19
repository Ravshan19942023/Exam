using Domain;

namespace Infrastructure;

public class PostService : IPostService
{
    public Task<bool> AddPostAsync(AddPostDto post)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePostAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetPostDto>> GetAllPostsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> GetPostAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdatePostAsync(UpdatePostDto post)
    {
        throw new NotImplementedException();
    }
}
