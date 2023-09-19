
using Domain;

namespace Infrastructure;

public interface ITeacherService
{
    Task<bool> AddTeacherAsync(AddTeacherDto teacher);
    Task<bool> DeleteTeacherAsync(int teacherId);
    Task<bool> UpdateTeacherAsync(UpdateTeacherDto teacher);
    Task<GetTeacherDto> GetTeacherAsync(int id);
    Task<List<GetTeacherDto>> GetTeacherAsync();
}
