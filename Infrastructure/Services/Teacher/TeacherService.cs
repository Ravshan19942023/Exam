

using Domain;

namespace Infrastructure;

public class TeacherService : ITeacherService
{
    public Task<bool> AddTeacherAsync(AddTeacherDto teacher)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTeacherAsync(int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<GetTeacherDto> GetTeacherAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetTeacherDto>> GetTeacherAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateTeacherAsync(UpdateTeacherDto teacher)
    {
        throw new NotImplementedException();
    }
}
