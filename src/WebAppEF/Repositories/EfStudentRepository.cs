using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppEF.EF;
using WebAppSP.Models;

namespace WebAppEF.Repositories
{
    public class EfStudentRepository : IStudentRepository
    {
        private readonly SchoolContext _schoolContext;

        public EfStudentRepository(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public async Task<Student> GetStudentByIdAsync(int tenantId, int studentId)
        {
            return await _schoolContext.Students.SingleOrDefaultAsync(x => x.StudentId == studentId && tenantId == tenantId);
        }

        public async Task<Student> UpdateStudentsGradeAsync(int tenantId, int studentId, string grade)
        {
            throw new NotImplementedException();
        }
    }
}
