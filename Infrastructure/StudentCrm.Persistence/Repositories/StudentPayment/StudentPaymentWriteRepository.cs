using StudentCrm.Application.Repositories.Role;
using StudentCrm.Application.Repositories.StudentPayment;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.StudentPayment
{
    public class StudentPaymentWriteRepository : WriteRepository<StudentCrm.Domain.Entities.StudentPayment>, IStudentPaymentWriteRepository
    {

        public StudentPaymentWriteRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
