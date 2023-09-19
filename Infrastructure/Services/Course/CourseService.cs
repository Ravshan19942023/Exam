

using Domain;

namespace Infrastructure;

public class CourseService : ICourseService
{
    public Task<bool> AddCourseAsync(AddCourseDto course)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCourseAsync(int courseId)
    {
        throw new NotImplementedException();
    }

    public Task<GetCourseDto> GetCourseAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetCourseDto>> GetCourseAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateCourseAsync(UpdateCourseDto course)
    {
        throw new NotImplementedException();
    }
}
