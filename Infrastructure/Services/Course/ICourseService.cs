

using Domain;

namespace Infrastructure;

public interface ICourseService
{
    Task<bool> AddCourseAsync(AddCourseDto course);
    Task<bool> DeleteCourseAsync(int courseId);
    Task<bool> UpdateCourseAsync(UpdateCourseDto course);
    Task<GetCourseDto> GetCourseAsync(int id);
    Task<List<GetCourseDto>> GetCourseAsync();
}

