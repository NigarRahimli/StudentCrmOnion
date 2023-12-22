using StudentCrm.Application.Repositories.Role;
using StudentCrm.Application.Repositories.Student;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Student
{
    public class StudentReadRepository : ReadRepository<StudentCrm.Domain.Entities.Student>, IStudentReadRepository
    {

        public StudentReadRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
