using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppSP.Models;

namespace WebAppSP.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        public Student GetStudentByIdAsync(int tenantId, int studentId)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudentsGradeAsync(int tenantId, int studentId, string grade)
        {
            throw new NotImplementedException();
        }
    }
}
