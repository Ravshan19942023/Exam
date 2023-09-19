using Domain;

namespace Infrastructure;
public interface IStudentService
{
    Task<bool> AddStudentAsync(AddStudentDto student);
    Task<bool> DeleteStudentAsync(int studentId);
    Task<bool> UpdateStudentAsync(UpdateStudentDto student);
    Task<GetStudentDto> GetStudentAsync(int id);
    Task<List<GetStudentDto>> GetStudentsAsync();
}
