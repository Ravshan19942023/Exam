using Domain;

namespace Infrastructure;
public class StudentService : IStudentService
{
    public Task<bool> AddStudentAsync(AddStudentDto student)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteStudentAsync(int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<GetStudentDto> GetStudentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetStudentDto>> GetStudentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateStudentAsync(UpdateStudentDto student)
    {
        throw new NotImplementedException();
    }
}
