using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppSP.Models;

namespace WebAppEF.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByIdAsync(int tenantId, int studentId);
        Task<Student> UpdateStudentsGradeAsync(int tenantId, int studentId, string grade);
    }
}
