using StudentCrm.Application.Repositories.Role;
using StudentCrm.Application.Repositories.Student;
using StudentCrm.Application.Repositories.StudentPayment;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.StudentPayment
{
    public class StudentPaymentReadRepository : ReadRepository<StudentCrm.Domain.Entities.StudentPayment>, IStudentPaymentReadRepository    {

        public StudentPaymentReadRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
