using WebAppSP.Models;

namespace WebAppSP.Repositories
{
    public interface IStudentRepository
    {
        Student GetStudentByIdAsync(int tenantId, int studentId);
        Student UpdateStudentsGradeAsync(int tenantId, int studentId, string grade);
    }
}
